using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GAMEOVER : MonoBehaviour {

    public GameObject UI;


    public void Retry()


    {

        SceneManager.LoadScene("Main");


    }


    public void Menu()

    {

        SceneManager.LoadScene("Start");
    }


}
