using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour {



	public string menuSceneName = "MainMenu";
	public Fader fader;


		
	public void Retry ()
	{

		fader.FadeTo (SceneManager.GetActiveScene ().name);

	}

		
	public void Menu()


	{
		fader.FadeTo (menuSceneName);


	}

}
