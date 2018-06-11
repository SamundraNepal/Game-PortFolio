using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraTouch : MonoBehaviour {

    private Touch initTouch = new Touch();
    public Camera cam;
    private float Movex = 0f;
    private float moveY = 0f;
    private Vector3 OriginalRot;
    public float RotationSpeed = 0.5f;
    public float Direction = -1f;


    public void Start()
    {

        OriginalRot = cam.transform.eulerAngles;
        Movex = OriginalRot.x;
        moveY = OriginalRot.y;
    }

    public void FixedUpdate()
    {
            foreach (Touch touch in Input.touches)
            {


            int id = touch.fingerId;

            


            if (touch.phase == TouchPhase.Began)
            {

                initTouch = touch;

                if(EventSystem.current.currentSelectedGameObject != null)
            {

                }



            }
            else if (touch.phase == TouchPhase.Moved)
            {

                //Swipping();

                float DeltaX = initTouch.position.x - touch.position.x;
                float DeltaY = initTouch.position.y - touch.position.y;
                Movex -= DeltaY * Time.deltaTime * RotationSpeed * Direction;
                moveY += DeltaX * Time.deltaTime * RotationSpeed * Direction;

                Movex = Mathf.Clamp(Movex, -45f, 45f);
                cam.transform.eulerAngles = new Vector3(Movex, moveY, 0f);


            }
            else if (touch.phase == TouchPhase.Ended)
            {

                initTouch = touch;

              
               
            }

        }
            


        

    }


}
