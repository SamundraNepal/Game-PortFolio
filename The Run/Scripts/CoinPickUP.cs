using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinPickUP : MonoBehaviour {


	public GameObject effect;

	public int CoinValue = 1;







	void Start()



	{


		CoinValue = 1;

	}



	void  OnTriggerEnter( Collider yelow)


	{


		if (yelow .tag == "PLAYER") {



	
			ScoreUI.currentScore += CoinValue;




			if (effect) {
				
				GameObject NewEffect = (GameObject) Instantiate (effect, transform.position, Quaternion.identity);

				Destroy (NewEffect.gameObject , 0.5f);

			}




			Destroy (gameObject);

		//	if (yelow.gameObject.name == "Coin") {

			//	Destroy (yelow.gameObject);
		//	}
		
	


		}
	

	}





}
