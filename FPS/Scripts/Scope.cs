using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope : MonoBehaviour {



    public Animator animator;

    public bool IsScoped = false;

    public GameObject Scoped;

    public GameObject Cam2;




     void Update()
    {


        if (Input.GetButtonDown("Fire2"))

        {

            IsScoped  = !IsScoped;

            animator.SetBool("SniperScope", IsScoped);

            

            if (IsScoped)
                StartCoroutine(Onscopped());

            else

                Unscoped();
            }


    }


    public void Unscoped()

    {

        Scoped.SetActive(false);
        Cam2.SetActive(true);

    }


    IEnumerator Onscopped()
    {

        yield return new WaitForSeconds(2.15f);

        Scoped.SetActive(true);
        Cam2.SetActive(false);
        
    }


    
    


    


}
