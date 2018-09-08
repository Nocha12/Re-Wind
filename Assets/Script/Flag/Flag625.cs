using UnityEngine;
using System.Collections;

public class Flag625 : MonoBehaviour {
	private BoxCollider2D coll;

	public GameObject alert;

	void Start()
	{
		coll = GetComponent<BoxCollider2D> ();
	}

	void Update () {
		if(Input.touchCount > 0 && FlagControler.isFlag){
			Vector3 ray;

			if (Input.GetTouch (0).phase.Equals (TouchPhase.Began)) {
				ray = Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position);
				Vector2 touchPos = new Vector2 (ray.x, ray.y);

				if (coll.Equals (Physics2D.OverlapPoint (touchPos))) {
					if (coll.CompareTag ("625Flag")) {
						alert.SetActive (true);
						FlagControler.isFlag = false;
					}
				}
			}
		}
		if(Input.GetMouseButtonDown(0)){
			Vector3 ray;

			ray = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Vector2 touchPos = new Vector2 (ray.x, ray.y);

			if (coll.Equals (Physics2D.OverlapPoint (touchPos))) {
				if (coll.CompareTag ("625Flag")) {
					alert.SetActive (true);
					FlagControler.isFlag = false;
				}
			}
		}
	}
}
