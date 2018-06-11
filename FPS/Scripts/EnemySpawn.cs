using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawn : MonoBehaviour {


    public PlayerHealth health;

    public GameObject Enemy;

    public float SpawnTime = 3f;

    public GameObject UI;

    public Transform[] spwanPoints;


    void Start()
    {


      

        InvokeRepeating("Spwan", SpawnTime, SpawnTime);


    }


    public void Spwan()
    {

        if (health.Health.value <3)

        {


            UI.SetActive (true);

            Time.timeScale = 0f;

            return;

        }

        int SpwanPointIndex = Random.Range(0, spwanPoints.Length);

        Instantiate(Enemy, spwanPoints[SpwanPointIndex].position, spwanPoints[SpwanPointIndex].rotation);



    }


}
