using UnityEngine;
using System.Collections;

public class Quiz3 : MonoBehaviour {
	private BoxCollider2D coll;
	public GameObject GameOver;
	public GameObject Quiz;

	void Start()
	{
		coll = GetComponent<BoxCollider2D> ();
	}

	IEnumerator GoToMain()
	{
		yield return new WaitForSeconds (3f);
		Application.LoadLevel("StartScene");
	}

	void Update () {
		if(Input.touchCount > 0){
			Vector3 ray;

			if (Input.GetTouch (0).phase.Equals (TouchPhase.Began)) {
				ray = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				Vector2 touchPos = new Vector2 (ray.x, ray.y);

				if (coll.Equals (Physics2D.OverlapPoint (touchPos))) {
					if (coll.CompareTag ("No")) {
						Quiz.SetActive (false);
						Time.timeScale = 1;
					}
					if (coll.CompareTag ("Yes")) {
						Quiz.SetActive (false);
						Time.timeScale = 1;
						GameOver.SetActive (true);
						GameManager.check = true;
					}
				}
			}
		}
		if(Input.GetMouseButtonDown(0)){
			Vector3 ray;

			ray = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Vector2 touchPos = new Vector2 (ray.x, ray.y);

			if (coll.Equals (Physics2D.OverlapPoint (touchPos))) {
				if (coll.CompareTag ("No")) {
					Quiz.SetActive (false);
					Time.timeScale = 1;
				}
				if (coll.CompareTag ("Yes")) {
					Quiz.SetActive (false);
					Time.timeScale = 1;
					GameOver.SetActive (true);
					GameManager.check = true;
				}
			}
		}
	}
}
