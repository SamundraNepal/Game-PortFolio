using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {



    public GameObject GameOverUI;


    public void Retry()

    {

        Time.timeScale = 1f;
        SceneManager.LoadScene("FPS");

    }


    public void MainMenu()

    {

        SceneManager.LoadScene("MainMenu");

    }


    public void Quit()

    {

        Application.Quit();

    }




}
