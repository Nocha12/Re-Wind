using UnityEngine;
using System.Collections;

public class NotifySeoul : MonoBehaviour {
	private BoxCollider2D coll;

	public GameObject alert;

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
						alert.SetActive (false);
						FlagControler.isFlag = true;
					}
					if (coll.CompareTag ("Yes")) {
						Application.LoadLevel("Soccer");
						FlagControler.isFlag = true;
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
					alert.SetActive (false);
					FlagControler.isFlag = true;
				}
				if (coll.CompareTag ("Yes")) {
					Application.LoadLevel("Soccer");
					FlagControler.isFlag = true;
				}
			}
		}
	}
}
