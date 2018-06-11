using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelComplete : MonoBehaviour {




	public bool LevelCOmplete = false;

	public GameObject gameLevelUI;




	void Start()


	{

		LevelCOmplete = false;

	}




	void OnTriggerEnter( Collider obj)


	{

		if (obj.gameObject.tag == "PLAYER") {



			WinLevel ();
			GameObject.Find ("PLAYER").GetComponent<playerMOvemnets> ().enabled = false;
			GameObject.Find ("GameMaster").GetComponent<ScoreUI> ().enabled = false;

		

}



}




	public void WinLevel()


	{

		LevelCOmplete = true;
		gameLevelUI.SetActive (true);	

}

		
}

