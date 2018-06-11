using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenuUI : MonoBehaviour {



    public GameObject PauseMenuBotton;
   






    public void Update()
    {
        

        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P) )
        {


            GamePaused();

        }

    }


    public void GamePaused()


    {


        PauseMenuBotton.SetActive(!PauseMenuBotton.activeSelf);
        if (PauseMenuBotton.activeSelf)
        {

            Time.timeScale = 0f;

        }
        else

        {

            Time.timeScale = 1f;
        }


    }


    public void Play()
    {



        PauseMenuBotton.SetActive(!PauseMenuBotton.activeSelf);
        if (PauseMenuBotton.activeSelf)
        {

            Time.timeScale = 0f;

        }
        else

        {

            Time.timeScale = 1f;
        }

    }


    public void Menu()
    {



        SceneManager.LoadScene("Menu");

        Time.timeScale = 1f;
    }


    public void Retry()
    {



        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;


    }

}


