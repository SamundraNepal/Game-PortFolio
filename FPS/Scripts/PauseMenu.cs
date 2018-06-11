using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject PauseUI;



    public void Update()
    {


        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {

            Toggle();

        }


    }



    public void Toggle()

    {

        PauseUI.SetActive(!PauseUI.activeSelf);

        if (PauseUI.activeSelf)

        {


            Time.timeScale = 0f;

        }
        else

        {

            Time.timeScale = 1f;

        }

    }

    public void Continue()

    {

        PauseUI.SetActive(!PauseUI.activeSelf);

        if (PauseUI.activeSelf)

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

        SceneManager.LoadScene("MainMenu");
        
        
    }



    public void Retry()

    {

        Time.timeScale = 1f;
        SceneManager.LoadScene("FPS");

    }




}
