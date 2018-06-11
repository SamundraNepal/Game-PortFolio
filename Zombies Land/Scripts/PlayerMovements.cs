using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour {


    public float Speed = 10f;
    public float JumpSpeed = 10f;
    public float LookSensetivity = 10f;
  
    

    PlayerMotor Motor;


    public void Start()
    {

        Motor = GetComponent<PlayerMotor>();
       

    }



    void Update () {

        // Calcuate the movements of the 3D vectors.

        
        

        float MoveLeftright =Input.GetAxisRaw("Horizontal");
           float MoveForward = Input.GetAxisRaw("Vertical");


            Vector3 _Movex = transform.right * MoveLeftright;
            Vector3 _Movey = transform.forward * MoveForward;
            //Combining the tow movements.

            Vector3 _Velocity = (_Movex + _Movey).normalized * Speed;
            // Apply Movements...
            Motor.Move(_Velocity);

         
        if(Input.GetKey(KeyCode.Space))
        {

        transform.Translate ( Vector3.up * JumpSpeed *Time.fixedDeltaTime);

        }


        // Calculate the rotation of the 3d vector


     //   float _Xrot = CnInputManager.GetAxisRaw("Mouse X");

       // Vector3 _rotation = new Vector3(0f, _Xrot, 0f) * LookSensetivity;

        // Apply rotation

      //  Motor.Rotate(_rotation);


        //Calculate Camera Rotation

     //   float _Yrot = CnInputManager.GetAxisRaw("Mouse Y");

       // float _CameraRotation = _Yrot * LookSensetivity;
//
        //Apply Camera Rotation

      //  Motor.CameraRotation(_CameraRotation);
		
	}
}
