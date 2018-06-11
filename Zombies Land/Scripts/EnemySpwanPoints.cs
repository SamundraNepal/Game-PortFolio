using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpwanPoints : MonoBehaviour {


    public GameObject Enemy;

    public float SpwanTime = 3f;

    public Transform[] SpwanPoints;

    Playerhealth health;



    public void Start()
    {

        InvokeRepeating("Spwan", SpwanTime, SpwanTime);
        health = GetComponent<Playerhealth>();

    }





    public void Spwan()
    {



        int SpwanPointIndex = Random.Range(0, SpwanPoints.Length);

       Instantiate(Enemy, SpwanPoints[SpwanPointIndex].transform.position, SpwanPoints[SpwanPointIndex].transform.rotation);

       
    }
}
