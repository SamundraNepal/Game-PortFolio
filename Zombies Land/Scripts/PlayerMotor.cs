using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMotor : MonoBehaviour {


    [SerializeField]
    private Camera cam;
    private Vector3 Velocity = Vector3.zero;
    private Vector3 Rotation = Vector3.zero;
    private float CameraRotationx = 0f;
    private float CurrentCameraRotation = 0f;
  private float CameraLimit = 85f;



    Rigidbody rb;



    public void Start()
    {

        rb = GetComponent<Rigidbody>();

    }



    // get a movement vector
    public void Move(Vector3 _velocity)
    {

        Velocity = _velocity;
    }

    //Get a Rotaion in 3d Vector

     public void Rotate(Vector3 _Rotation)
    {

        Rotation = _Rotation;

    }


    // Get Camera Rotation

        public void CameraRotation(float _CameraRotation)
    {

        CameraRotationx = _CameraRotation;

    }



    public void FixedUpdate()
    {

        FinalMovements();
        FinalRotation();
       FinalCameraRotation();
    }



    // Perform Movements 
    public void FinalMovements()
    {

        if(Velocity != Vector3.zero)
        {


            rb.MovePosition(rb.position + Velocity * Time.deltaTime);
        }

    }


    //Perform Rotation

    public void FinalRotation()
    {

        rb.MoveRotation(rb.rotation * Quaternion.Euler(Rotation));

    }

    //Perform Final Rotation

   public void FinalCameraRotation()
    {

        if(cam != null)
        {

            //Set rotation and clamp it

            CurrentCameraRotation -= CameraRotationx;

            CurrentCameraRotation = Mathf.Clamp(CurrentCameraRotation, -CameraLimit, CameraLimit);

            //Set our rotation ot the tranform of the camera

            cam.transform.localEulerAngles = new Vector3(CurrentCameraRotation, 0f, 0f);


        }

    }


}
