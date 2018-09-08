using UnityEngine;
using System.Collections;

public class Wave : MonoBehaviour {
	private int direction = 1;

	void Start () {
		StartCoroutine (WaveMove ());
		StartCoroutine (ChangeDirection ());
	}

	IEnumerator WaveMove(){
		while (true) {
			transform.Translate (new Vector2 (direction * Time.deltaTime, 0));

			yield return true;
		}
	}

	IEnumerator ChangeDirection(){
		while (true) {
			direction *= -1;

			yield return new WaitForSeconds(1f);
		}
	}
}
