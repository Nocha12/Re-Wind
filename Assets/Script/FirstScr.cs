using UnityEngine;
using System.Collections;

public class FirstScr : MonoBehaviour {
	void Update () 
	{
		if(Application.platform.Equals(RuntimePlatform.Android))
		if(Input.GetKey(KeyCode.Escape))
			Application.Quit();
	}

	public void GoToCountryMap()
	{
		Application.LoadLevel("CountryMap");
	}

	public void GoToHowToPlay()
	{
		Application.LoadLevel("HowToPlay");
	}
}
