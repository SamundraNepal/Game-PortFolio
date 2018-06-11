using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;
public class MobilePlayerMovements : MonoBehaviour {


    public float PlayerMoveSpeed = 10f;
 


   

    Rigidbody rb;


    public void Awake()
    {

        rb = GetComponent<Rigidbody>();
      

    }

    public void Update()
    {



        float MoveX = CrossPlatformInputManager.GetAxis("Horizontal") * PlayerMoveSpeed;
        float Movey = CrossPlatformInputManager.GetAxis("Vertical") * PlayerMoveSpeed;

        transform.Translate(MoveX, 0, Movey);

      //  rb.velocity = new Vector3(MoveX, 0, Movey);


       
        
    }




}
