using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingBar : MonoBehaviour {

    public Slider LoadingBars;



    public void Update()
    {
        

        if(LoadingBars.value > 0)
        {

            LoadingBars.value -= 0.1f;


        }



        if(LoadingBars.value < 1)
        {

            SceneManager.LoadScene("Player");


        }


    }


}
