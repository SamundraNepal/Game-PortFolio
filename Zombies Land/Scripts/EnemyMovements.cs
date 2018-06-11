using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovements : MonoBehaviour {

    public GameObject Camera;
    public float Speed;
    public float RotationMove;




    public void Awake()
    {

        Camera = GameObject.FindGameObjectWithTag("MainCamera");

    }


    public void Update()
    {


        float EnemyMove = Speed * Time.deltaTime;
        float Rotation = RotationMove * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Camera.transform.position, EnemyMove);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Camera.transform.rotation, Rotation);


      

    }

  

}
