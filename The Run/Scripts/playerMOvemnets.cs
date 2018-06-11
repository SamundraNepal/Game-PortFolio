using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMOvemnets : MonoBehaviour {


	public float speed;

	public float moveSpeed;




	void Update()


	{


			transform.Translate (Vector3.forward * speed * Time.fixedDeltaTime, Space.Self);



			float x = Input.GetAxisRaw ("Horizontal");
			transform.Translate (x, 0, 0);



			if (Input.GetKey ("space")) {

				transform.Translate (Vector3.up * moveSpeed * Time.deltaTime);

			}


	}





}
