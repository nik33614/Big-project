using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


	public int Scores;
	public UnityEngine.UI.Text ScoresText;
	public AudioSource CoinAudio;
	public AudioSource CrashAudio;


	void Start()
	{
		Cursor.visible = false;
	}


	void Update () 
	{
		Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.position = new Vector3(pos.x, pos.y, 0);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag == "Asteroid")
		{
			StartCoroutine(Lose());
		}


		if(col.tag == "Coin")
		{
			Destroy(col.gameObject);
			Scores += 1;
			ScoresText.text = Scores.ToString();

			CoinAudio.Play();

		}

		}
		



	IEnumerator Lose()
	{
		CrashAudio.Play();
		GetComponent<AudioSource>().Play();
		GetComponent<SpriteRenderer>().enabled = false;
		GetComponent<PolygonCollider2D>().enabled = false;
		yield return new WaitForSeconds(1);
		Application.LoadLevel(0 );
	}
}
