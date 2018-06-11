using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteLevel : MonoBehaviour {

	public string menuSceneName = "MainMenu";

	public Fader fader;


	public string nextLevel = "Level02";

	public 	int levelToUnlock = 2;


	public void Continue ()
	{


		PlayerPrefs.SetInt ("levelReached" , levelToUnlock);
		fader.FadeTo (nextLevel);

	}

	public void Menu ()


	{


		fader.FadeTo (menuSceneName);
	}

}
