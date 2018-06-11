using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunShoot : MonoBehaviour {


    public Camera FpsCam;
    public int Damage = 10;
    public GameObject HitEffets;
    public Transform FirePoint;
    public GameObject Guneffect;

    [Header("AMMO bullets : ")]
    [SerializeField]

    public int MaxBullets = 30;
    public Text Bullets;
    public  int CurrentBullets;
    AudioSource audio;


    public void Start()
    {

     
        audio = GetComponent<AudioSource>();
        CurrentBullets = MaxBullets;
        Bullets.text = CurrentBullets.ToString();
     
       


    }


        public void Update()
        {


        
       

        if (CurrentBullets <= 0)
            {

            
           
            StartCoroutine(Reload());
           
            return;

           

        }


     


       


      /*  if (Input.GetButtonDown("Fire1"))
            {

                GameObject effects = Instantiate(Guneffect, FirePoint.position, FirePoint.rotation);

                Destroy(effects, 1f);

                Shoot();

            }*/


      



    }

    public void Fire()
    {

        GameObject effects = Instantiate(Guneffect, FirePoint.position, FirePoint.rotation);


        Destroy(effects, 1f);

        Shoot();
    }



    public void Shoot()
        {

            audio.Play();
            CurrentBullets--;
            Bullets.text = CurrentBullets.ToString();

            RaycastHit Hit;

            if (Physics.Raycast(FpsCam.transform.position, FpsCam.transform.forward, out Hit))
            {




                Debug.Log(Hit.transform.name);

                EnemyHealth Health = Hit.transform.GetComponent<EnemyHealth>();

                if (Health != null)
                {

                    Health.TakeDamage(Damage);

                }

                GameObject HitEffect = Instantiate(HitEffets, Hit.point, Quaternion.LookRotation(Hit.normal));
                Destroy(HitEffect, 1f);
            }

        }



    IEnumerator Reload()
    {

        

        yield return new WaitForSeconds(0.1f);

        CurrentBullets = MaxBullets;
        Bullets.text = CurrentBullets.ToString();
      



    }


    


}
