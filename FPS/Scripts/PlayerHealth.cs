using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

  

    public Image damageImage;

    public float flashSpeed = 5f; 
    

    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);



    public Slider Health;


   

    bool damaged;

    bool Isdead;


    void Update()
    {


        if (damaged)
        {
            
            damageImage.color = flashColour;
        }
      
        else
        {
           
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }

        damaged = false;


    }


    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Bullet"  && Health.value > 0)


        {
           

            damaged = true;

           

            Health.value -= 10;
        }

           
            


        }

    }









