using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameCompleteButtons : MonoBehaviour {




	public void Next()
	{


		SceneManager.LoadScene ("Level02");


	}


	public void Menu()


	{

		SceneManager.LoadScene ("MENU");


	}
}


