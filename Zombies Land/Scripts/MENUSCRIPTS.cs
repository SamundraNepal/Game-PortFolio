﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENUSCRIPTS : MonoBehaviour {



    public void Start()
    {


        Time.timeScale = 1f;
    }

    public void Play()

    {

        SceneManager.LoadScene("LoadingLevel");
        Time.timeScale = 1f;


    }

    public void Quit()
    {

        Application.Quit();
    }


}
