using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(AudioSource))]
public class Playerhealth : MonoBehaviour {


    public Image DamageColor;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    public Slider Healthbar;
    public GameObject GameOverUI;
    public GameObject ScoreUI;

    public AudioClip DeathEfects;
    public AudioClip HurtSound;
    AudioSource audioSource;
    


    bool Damaged;



    public void Start()
    {

        audioSource = GetComponent<AudioSource>();
        GameOverUI.SetActive(false);

    }


    public void Update()
    {




        if(Damaged)
        {


            DamageColor.color = flashColour;


        }
        else
        {

            DamageColor.color = Color.Lerp(DamageColor.color, Color.clear, flashSpeed * Time.deltaTime);
        }

        Damaged = false;


    


    }




    public void OnCollisionEnter(Collision Other)
    {
        if(Other.gameObject.tag == "Enemy" && Healthbar.value > 0 ) 
        {

            Damaged = true;

            Healthbar.value -= 1;
            




        }
        else

        {

            if(Healthbar.value < 1)
            {

                audioSource.PlayOneShot(DeathEfects);
                Time.timeScale = 0f;
                GameOverUI.SetActive(true);
                ScoreUI.SetActive(false);
            }
        }



        if(Other.gameObject.tag == "Enemy")
        {

            audioSource.PlayOneShot(HurtSound);


        } else


        {

            return;


        }

    }

 





}
