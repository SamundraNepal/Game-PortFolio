using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {



	public string levelToLoad = "MainLevel";


	public Fader fader;
	public void Play ()

	{


		fader.FadeTo (levelToLoad);


	}

	public void Quit ()

	{

		Debug.Log ("Quit");

		Application.Quit ();

	}

}
