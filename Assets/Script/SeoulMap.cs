using UnityEngine;
using System.Collections;

public class SeoulMap : MonoBehaviour {

	private BoxCollider2D coll;

	void Update () {
		if(Application.platform.Equals(RuntimePlatform.Android))
		if(Input.GetKey(KeyCode.Escape))
			Application.LoadLevel("CountryMap");
	}
}
