using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SwardSold : MonoBehaviour {
	private GameObject Other;
	private bool isMove = true;
	public int Helth = 10;
	public Image img;

	void Start()
	{
		img = GameManager.EnemyBar;
	}

	void Update () {
		if(isMove)
			transform.Translate(Vector2.right * Time.deltaTime * 5);
		if (Helth <= 0)
			Destroy (gameObject);
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.transform.CompareTag ("EStation")) {
			isMove = false;
			StartCoroutine (Attack ());
		}
		if (coll.transform.CompareTag ("Enemy")) {
			Other = coll.gameObject;
			isMove = false;
			StartCoroutine (Attacked()); 
		}
	}

	void OnDestroy ()
	{
		StopAllCoroutines ();
	}

	IEnumerator Attacked()
	{
		while (Other) {
			Helth -= 1;
			yield return new WaitForSeconds (0.5f);
		}
		isMove = true;
	}

	IEnumerator Attack()
	{
		while (this) {
			img.fillAmount -= 0.015f;
			yield return new WaitForSeconds (0.5f);
		}
		isMove = true;
	}
}
