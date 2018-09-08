using UnityEngine;
using System.Collections;

public class CountryMap : MonoBehaviour {

	private BoxCollider2D coll;

	void Start()
	{
		coll = GetComponent<BoxCollider2D> ();
	}

	void Update () {
		if(Application.platform.Equals(RuntimePlatform.Android))
		if(Input.GetKey(KeyCode.Escape))
			Application.LoadLevel("StartScene");

		if(Input.touchCount > 0){
			Vector3 ray;

			if (Input.GetTouch (0).phase.Equals (TouchPhase.Began)) {
				ray = Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position);
				Vector2 touchPos = new Vector2 (ray.x, ray.y);

				if (coll.Equals (Physics2D.OverlapPoint (touchPos))) {
					if (coll.CompareTag ("Ground")) {
						Application.LoadLevel ("SeoulMap");
					}
				}
			}
		}
	}
}
