using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreValue : MonoBehaviour {


    public static int Score;

     Text text;

    public Text highScore;


 

     




    public void Awake()
    {

        text = GetComponent<Text>();

        Score = 0;

        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }


    public void Update()
    {
        text.text = "SCORE :  " + Score.ToString();


        if(Score > PlayerPrefs.GetInt("HighScore" , 0))

        {

            PlayerPrefs.SetInt("HighScore", Score);

            highScore.text = Score.ToString();
        }


    }




}
