using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxFall : MonoBehaviour {





	[SerializeField]

	public bool Fall = false;

	public GameObject maxFall;

	public GameObject fallImpact;


	public float MaxFallDistance = -10;




	void Start()


	{

		Fall = false;

	}

	void Update()
	{

		if ( transform.position.y <  MaxFallDistance) {




			if (fallImpact) {
			


				GameObject Fallimpaact = (GameObject)Instantiate (fallImpact, transform.position, transform.rotation);

				Destroy (Fallimpaact.gameObject,1.5f);
			
			}
				


			Destroy (gameObject);

			GameObject.Find ("GameMaster").GetComponent<ScoreUI> ().enabled = false;

			DownWardFall ();

		}
	}

		






	public void DownWardFall()


	{

		Fall = true;
		maxFall.SetActive (true);





	}
}
