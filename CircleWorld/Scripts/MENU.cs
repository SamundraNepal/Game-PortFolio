using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MENU : MonoBehaviour {


    public GameObject UI;


    public Fader fader;

    public void Play()
    {

        Time.timeScale = 1f;

       fader.FadeTo("Main");

    }




    
    public void Quit()
    {

        Application.Quit();

    }


}
