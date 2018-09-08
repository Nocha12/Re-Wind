using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Slide : MonoBehaviour {
	public Camera cam;

	void Update () {
		if(Input.touchCount > 0)
			cam.transform.Translate(Input.GetTouch (0).deltaPosition.x * Time.deltaTime * 2, 0, 0);

		cam.transform.position = new Vector3(Mathf.Clamp(cam.transform.position.x, 0, 20.55f), 0, -10);
	}
}
