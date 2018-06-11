using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKiller : MonoBehaviour {




	public GameObject Impact;
	public  GameObject player;



	public  bool GameISOver;

	public  GameObject gameOverUI;




	void Start()
	{
		

		GameISOver = false;


	}




	void OnTriggerEnter(Collider col)
	{
	
	

		if (col.tag == "PLAYER") {




			if (Impact) {


		
				GameObject NewImpact= (GameObject) Instantiate (Impact, transform.position, Quaternion.identity);


				Destroy (NewImpact.gameObject, 1.5f);



			}

			Destroy (col.gameObject);


			Endgame ();


			GameObject.Find("GameMaster").GetComponent<ScoreUI> ().enabled = false;

					

		
		}


	}

	public void Endgame()


	{

		GameISOver = true;
		gameOverUI.SetActive (true);	

	}


}
