using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {

    
    public int CurrentHealth = 100;
    GunShoot Damage;
    public int ScoreToadd = 1;
    //public AudioClip EnemyHurtSound;
    AudioSource EmenySOund;

    public void Start()
    {

       
       
        Damage = GetComponent<GunShoot>();
        EmenySOund = GetComponent<AudioSource>();
    }



    public void TakeDamage(int Amount )

    {


        CurrentHealth -= Amount;
        EmenySOund.Play();


        if (CurrentHealth <= 1)
        {

            Die();
           


        }
        

    }


    public void Die()
    {
        Destroy(gameObject);
        ScoreValue.Score += ScoreToadd;
      

    }

}
