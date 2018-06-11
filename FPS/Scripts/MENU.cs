using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MENU : MonoBehaviour {




    public GameObject Menu;




    public void Play()

    {

        Time.timeScale = 1f;

        SceneManager.LoadScene("FPS");

    }


    public void Quit()

    {

        Application.Quit();

    }




}
