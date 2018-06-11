using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{


    public Transform player;

    public Camera TargetCamera;

   public float range = 50.0f;

    public float bulletImpulse = 20.0f;


    private bool onRange = false;

    public Rigidbody projectile;


    PlayerHealth health;





    void Start()
    {

        health = GetComponent<PlayerHealth>();

        float rand = Random.Range(1.0f, 2.0f);
        InvokeRepeating("Shoot", 2, rand);
    }




    void Shoot()
    {

        if (onRange)
        {

            Rigidbody bullet = Instantiate (projectile, transform.position + transform.forward, transform.rotation);

            bullet.AddForce(transform.forward * bulletImpulse, ForceMode.Impulse);

            Destroy(bullet.gameObject, 2);



        }



    }





    void Update()
  {


       onRange = Vector3.Distance(transform.position, player.position) < range;

      

       

        if (onRange)
           transform.LookAt(player.position + TargetCamera.transform.rotation * Vector3.left , TargetCamera.transform.rotation * Vector3.up);
        


    }

}










