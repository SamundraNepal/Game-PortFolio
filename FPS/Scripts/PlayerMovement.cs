using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[RequireComponent(typeof ( Rigidbody))]



public class PlayerMovement : MonoBehaviour {



    [SerializeField]

    private Camera cam;

    private Vector3 Velocity = Vector3.zero;
    private Vector3 rotation = Vector3.zero;
    private float CamRotationx = 0f;
    private float CurrentCameraRotation = 0f;
    private Vector3 ThrusterSpeed = Vector3.zero;

    [SerializeField]
    private float CameraLimit = 85f;

    private Rigidbody rb;


     void Start()
    {


        

        rb = GetComponent<Rigidbody>();


    }

    // Gets a MOvements
        public  void Move (Vector3 _velocity)

    {

        Velocity = _velocity;
    }




    // Gets the value of the Rotation.
    public void Rotation(Vector3 _rotation)
      
    {
        rotation = _rotation;
    }


    // Gets the value if the Camera Rotation.

    public void Camerarotation(float _CameraRotation)

    {

        CamRotationx = _CameraRotation;


    }
     // Gets the value of the Apply Thurster.


    public void ApplyThruster(Vector3 _ApplyThruster)
    {

        ThrusterSpeed = _ApplyThruster;


    }




    // Runs physic iteration
        void FixedUpdate()
    {

        PerforMovemets();
        PerformRotation();
        PerformCameraRotation();
        Thrusterpower();


    }

    // Perfrom MOvements based on velocity variables.

    void PerforMovemets()


    {
        if (Velocity != Vector3.zero)

        {

            rb.MovePosition(rb.position + Velocity * Time.fixedDeltaTime);
        }
    }


    // Perform thruster based on player input.
    void Thrusterpower()

    {


        if (ThrusterSpeed != Vector3.zero)

        {

            rb.AddForce(ThrusterSpeed * Time.fixedDeltaTime, ForceMode.Acceleration);

        }




    }




    // Perform Rotation based on the velocity Variables.


    void PerformRotation()

    {

        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation));

    }


    void PerformCameraRotation()

    {
        if (cam != null)

        { 

            // set our rotation and clap it.

            CurrentCameraRotation -= CamRotationx;
            CurrentCameraRotation = Mathf.Clamp(CurrentCameraRotation, -CameraLimit, CameraLimit);
            
            
            // set our rotation to the transform of the camera. 



            cam.transform.localEulerAngles = new Vector3(CurrentCameraRotation, 0f, 0f);

        }

    }


   










}
