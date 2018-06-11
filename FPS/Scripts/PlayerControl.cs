using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



[RequireComponent(typeof ( PlayerMovement))]
[RequireComponent(typeof(ConfigurableJoint))]


public class PlayerControl : MonoBehaviour {




    PlayerHealth Health;

    [SerializeField]
    private  float speed = 5f;

    [SerializeField]

    private float Mouselook = 5f;

    private PlayerMovement movement;

    private ConfigurableJoint joint;


    [Header("Spring Settings :")]
    [SerializeField]

    private JointDriveMode jointMode;

    [SerializeField]
    private float jointSpring = 20f;

    [SerializeField]
    private float jointMaxForce = 40f;


    [SerializeField]
    private float thrusterSpeed = 1000f;
    public Slider ThrusterTime;

     void Start()
    {


        Health = GetComponent<PlayerHealth>();
        movement = GetComponent<PlayerMovement>();
        joint = GetComponent<ConfigurableJoint>();
        SetjointSettings (jointSpring);
        

    }


    void Update()

    {

        if (Health.Health.value < 1)

        {

            Debug.Log(" Player Died");

        }


        // calculate the speed of the movements in 3D vector.

        float _Xmov = Input.GetAxisRaw("Horizontal");
        float _Zmov = Input.GetAxisRaw("Vertical");

        Vector3 _moveHorizontal = transform.right * _Xmov;


        Vector3 _moveVertical = transform.forward * _Zmov;


        // Final movement Vector
        Vector3 _velocity = (_moveHorizontal + _moveVertical).normalized * speed;

        // Apply movement

        movement.Move(_velocity);

        // Calculate the Rotation of the 3D vector. This is for Trunning around.


        float _Yrotation = Input.GetAxisRaw("Mouse X");

        Vector3 _rotation = new Vector3(0f, _Yrotation, 0f) * Mouselook;


        //Apply Rotation

        movement.Rotation(_rotation);




        // Calculate the Tilting of the Camera rotation in 3D vector.

        float _Xcamera = Input.GetAxisRaw("Mouse Y");
        float _CameraRotation = _Xcamera * Mouselook;


        // Apply Camera Rotation

        movement.Camerarotation(_CameraRotation);



        // Apply thruster speed accourding to player input.

        Vector3 _thrusterSpeed = Vector3.zero;
        // Apply thruster force.

        if (Input.GetButton("Jump")  && ThrusterTime.value > 0)

        {

            ThrusterTime.value -= 0.5f;

          

            _thrusterSpeed = Vector3.up * thrusterSpeed;

            SetjointSettings(0f);
        }
        else

        {
            ThrusterTime.value += 0.1f;
            SetjointSettings(jointSpring);



        }

       
        movement.ApplyThruster(_thrusterSpeed);




    }

    private void SetjointSettings(float _jointSpring)


    {

        joint.yDrive = new JointDrive
        {

            mode = jointMode,
            positionSpring = _jointSpring,
            maximumForce = jointMaxForce
        };



    }



}
