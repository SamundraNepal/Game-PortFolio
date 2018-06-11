using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour {






	public void Retry()


	{

		int scene = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(scene, LoadSceneMode.Single);




	}




	public void Menu()


	{

		SceneManager.LoadScene ("MENU");


	}
}
