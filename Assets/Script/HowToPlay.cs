using UnityEngine;
using System.Collections;

public class HowToPlay : MonoBehaviour {
	public GameObject[] Scene = new GameObject[3];

	private int i = 0;

	void Update()
	{
		if(Application.platform.Equals(RuntimePlatform.Android))
		if(Input.GetKey(KeyCode.Escape))
			Application.LoadLevel("StartScene");
	}

	public void Left()
	{
		if (i != 0) {
			Scene [i--].SetActive (false);
			Scene [i].SetActive (true);
		}
	}

	public void Right()
	{
		if(i.Equals(2))
			Application.LoadLevel("CountryMap");
		if (i != 2) {
			Scene [i++].SetActive (false);
			Scene [i].SetActive (true);
		}
	}
}
