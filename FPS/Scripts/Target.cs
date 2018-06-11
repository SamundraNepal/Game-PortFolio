using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {


    public int ScoreValue = 10;

    public float Health = 50f;

    AudioSource EnemyDie;

    public AudioClip EnemySound;

    public GameObject ExplosionEffect;

    public static Vector3 position { get; private set; }

    void Start()
    {

       
        EnemyDie = GetComponent<AudioSource>();



    }

    public void TakeDamage(float Amount)

    {

        Health -= Amount;


        if (Health <= 0)

        {

            //   Anime.SetTrigger("Die");
           
            EnemyDie.PlayOneShot(EnemySound);


            GameObject ImapctExplo = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);

            Destroy(ImapctExplo, 1f);

            Die();

        }


    }
     void Die()


    {

        Destroy(gameObject ,1f);

        ScoreUI.Score += ScoreValue;

    }

}
