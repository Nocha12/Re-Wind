using UnityEngine;
using System.Collections;

public class Quiz1 : MonoBehaviour {
	private BoxCollider2D coll;
	public GameObject GameOver;
	public GameObject Quiz;



	void Start()
	{
		coll = GetComponent<BoxCollider2D> ();
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
						GameOver.SetActive (true);
						Time.timeScale = 1;
						GameManager.check = true;
					}
					if (coll.CompareTag ("Yes")) {
						Quiz.SetActive (false);
						Time.timeScale = 1;
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
					Time.timeScale = 1;
					GameManager.check = true;
					Quiz.SetActive (false);
					GameOver.SetActive (true);
				}
				if (coll.CompareTag ("Yes")) {
					Quiz.SetActive (false);
					Time.timeScale = 1;
				}
			}
		}
	}
}
