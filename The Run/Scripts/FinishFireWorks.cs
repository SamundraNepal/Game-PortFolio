using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishFireWorks : MonoBehaviour {




	public ParticleSystem fireworks;





	void OnTriggerEnter(Collider effect)

	{


		if (effect.tag == "PLAYER") {
		
		
			Instantiate (fireworks, transform.position, transform.rotation);

		}

	}

}
