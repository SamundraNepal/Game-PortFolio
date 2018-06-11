using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour {


    public GameObject UI;



    public void Update()
    {


        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
        {

            Toggle();

        }


    }



    public void Toggle()

    {

        UI.SetActive(!UI.activeSelf);

        if (UI.activeSelf)

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

        UI.SetActive(!UI.activeSelf);

        if (UI.activeSelf)

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

        SceneManager.LoadScene("Start");

        Time.timeScale = 1f;
    }


}
