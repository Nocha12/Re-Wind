﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyPoo : MonoBehaviour {
	private GameObject Other;
	private bool isMove = true;
	public int Helth = 100;
	public Image img;

	void Start()
	{
		img = GameManager.PlayerBar;
	}

	void Update () {
		transform.Translate(Vector2.left * Time.deltaTime);
		if (Helth <= 0)
			Destroy (gameObject);
	}
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.transform.CompareTag ("Station")) {
			isMove = false;
			StartCoroutine (Attack ());
		}if (coll.transform.CompareTag ("Player")) {
			Other = coll.gameObject;
			isMove = false;
			StartCoroutine (Attacked ());
		}
	}

	IEnumerator Attacked()
	{
		while (Other) {
			Helth -= 1;
			yield return new WaitForSeconds (0.5f);
		}
		isMove = true;
	}

	void OnDestroy ()
	{
		StopAllCoroutines ();
	}

	IEnumerator Attack()
	{
		while (this) {
			img.fillAmount -= 0.05f;
			yield return new WaitForSeconds (0.5f);
		}
		isMove = true;
	}
}
