using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseUI : MonoBehaviour {

	public    GameObject pauseUI;







	void Update()


	{

		if (Input.GetKeyDown (KeyCode.Escape) || Input.GetKeyDown (KeyCode.P)) {
		

			Toggle ();
		}

	}


	public void Toggle ()


	{
		pauseUI.SetActive (!pauseUI.activeSelf);

		if (pauseUI.activeSelf) {


			GameObject.Find ("PLAYER").GetComponent<playerMOvemnets> ().enabled = false;
			GameObject.Find("GameMaster").GetComponent <ScoreUI>().enabled = false;
		
			Time.timeScale = 0f;
		

		} else {
		
		

			GameObject.Find ("PLAYER").GetComponent<playerMOvemnets> ().enabled = true;
			GameObject.Find ("GameMaster").GetComponent<ScoreUI> ().enabled = true;

			Time.timeScale = 1f;

		}





	}


}
