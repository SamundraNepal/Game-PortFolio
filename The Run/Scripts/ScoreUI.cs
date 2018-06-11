using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ScoreUI : MonoBehaviour {



	public static int currentScore = 0;

	public float offsetY = 40;
	public float sizeX = 100;
	public float sizeY = 40;




	void Start()


	{

		currentScore = 0;

	}



	public void  OnGUI () {
		GUI.Box (new Rect (Screen.width/2-sizeX/2, offsetY, sizeX, sizeY), "Score: " + currentScore);
	}



}
