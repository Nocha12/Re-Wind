using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {
	public GameObject Qiz1;
	public GameObject Qiz2;
	public GameObject Qiz3;
	public Image Player;
	public Image Enemy;
	public GameObject Sward;
	public GameObject Gun;
	public GameObject Poo;
	public GameObject ESward;
	public GameObject EGun;
	public GameObject EPoo;
	public GameObject Clear;
	public GameObject GameOver;
	public Text Gold;
	private int nowGold = 0;
	static public Image PlayerBar;
	static public Image EnemyBar;
	public bool Q1 = true;
	public bool Q2 = true;
	public bool Q3 = true;
	public static bool check = false;
	public AudioSource AudS;
	public AudioClip dead;
	void Awake()
	{
		PlayerBar = Player;
		EnemyBar = Enemy;
	}

	void Start()
	{
		Gold.text = nowGold.ToString ();
		StartCoroutine (MakeESward());
		StartCoroutine (MakeEGun());
		StartCoroutine (MakeEPoo());
		StartCoroutine (UpMoney());
	}

	void Update()
	{
		if (check)
			StartCoroutine (GoToMain());
			
		if (Enemy.fillAmount <= 0.7 && Q1 && !check) {
			Qiz1.SetActive (true);
			Q1 = false;
			Time.timeScale = 0;
		}
		if (Enemy.fillAmount <= 0.4 && Q2 && !check) {
			Qiz2.SetActive (true);
			Q2 = false;
			Time.timeScale = 0;
		}
		if (Enemy.fillAmount <= 0.1 && Q3 && !check) {
			Qiz3.SetActive (true);
			Q3 = false;
			Time.timeScale = 0;
		}
		if (Player.fillAmount <= 0 && !check) {
			GameOver.SetActive (true);
			check = true;
		} else if (Enemy.fillAmount <= 0 && !check) {
			Clear.SetActive (true);
			check = true;
		}
	}

	public void MakeSward()
	{
		if (nowGold >= 10) {
			nowGold -= 10;
			Gold.text = "Gold : " + nowGold.ToString ();
			Instantiate (Sward, new Vector2 (-3.7f, -2.8f), Quaternion.identity);
		}
	}

	public void MakeGun()
	{
		if (nowGold >= 30) {
			nowGold -= 30;
			Gold.text = "Gold : " + nowGold.ToString ();
			Instantiate (Gun, new Vector2 (-3.7f, -2.8f), Quaternion.identity);
		}
	}

	public void MakePoo()
	{
		if (nowGold >= 70) {
			nowGold -= 70;
			Gold.text = "Gold : " + nowGold.ToString ();
			Instantiate (Poo, new Vector2 (-3.7f, -2.8f), Quaternion.identity);
		}
	}
		
	IEnumerator MakeESward()
	{
		while (true) {
			Instantiate (ESward, new Vector2 (23f, -2.8f), Quaternion.identity);
			yield return new WaitForSeconds (6f);
		}
	}
	IEnumerator MakeEGun()
	{
		while (true) {
			Instantiate (EGun, new Vector2 (23f, -2.8f), Quaternion.identity);
			yield return new WaitForSeconds (22f);
		}
	}
	IEnumerator MakeEPoo()
	{
		while (true) {
			Instantiate (EPoo, new Vector2 (23f, -2.8f), Quaternion.identity);
			yield return new WaitForSeconds (50f);
		}
	}

	IEnumerator	UpMoney()
	{
		while (true) {
			nowGold += 3;
			Gold.text = "Gold : " + nowGold.ToString ();
			yield return new WaitForSeconds (1f);
		}
	}

	IEnumerator GoToMain()
	{
		yield return new WaitForSeconds (3f);
		Application.LoadLevel("StartScene");
	}
}
