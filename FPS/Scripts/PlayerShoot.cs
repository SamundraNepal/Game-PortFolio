using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerShoot : MonoBehaviour {




    [Header("Reloading : ")]
    [SerializeField]
    public int MaxAmmo = 30;
    public Text Ammo;
    private int CurrentAmmo;
    public float ReloadTime = 2f;
    private bool Isreloading = false;
    public Animator Animator; 




    [Header("Gun Settings :")]
    [SerializeField]
    public GameObject HitEffect;
    public float ImpactForce = 30f;
    public float FireRate = 30f;
    private float NextTimeToFire = 0f;
    public AudioClip Source;
    public AudioClip ReloadMusic;
    AudioSource Audio;

   


    [SerializeField]
    private PlayerWeapon Weapon;
    public float Damage = 10f;


    [SerializeField]
    public ParticleSystem Flash;
  

    [SerializeField]
    private GameObject WeaponGFX;

    [SerializeField]

    private string WeaponLayerName = "Weapon";


    [SerializeField]
    private Camera cam;


    [SerializeField]

    private LayerMask mask;

    void Start()
    {


       

        if (Isreloading)
            return;

        Audio = GetComponent<AudioSource>();
        
      
    
        CurrentAmmo = MaxAmmo;
        Ammo.text = CurrentAmmo.ToString();

       
        if (cam == null)
        {
            Debug.Log("Error");

            this.enabled = false;

        }

         
        WeaponGFX.layer = LayerMask.NameToLayer(WeaponLayerName);

    }



     void OnEnable()
    {


        Isreloading = false;
        Animator.SetBool("Reloading", false);


    }

    void Update()
    {




        if (CurrentAmmo <= 0)
        {

            StartCoroutine(Reload());
            return;

        }


        if (Input.GetButtonDown("Fire1") && Time.time >= NextTimeToFire)
        {

            NextTimeToFire = Time.time + 2f / FireRate;
            Shoot();

        }

    }


    void Shoot()


    {


        Audio.PlayOneShot(Source);

        Flash.Play();

        CurrentAmmo--;

        Ammo.text = CurrentAmmo.ToString();


        RaycastHit _hit;

        if (Physics.Raycast (cam.transform.position , cam.transform.forward , out _hit , Weapon.Range, mask))
        {


           
            Debug.Log("We hit : " + _hit.collider.name);
          Target target = _hit.transform.GetComponent<Target>();

            if (target != null)
            {

                target.TakeDamage(Damage);

            }

            if (_hit.rigidbody != null)
            {

                _hit.rigidbody.AddForce(-_hit.normal * ImpactForce);

            }


            GameObject ImpactGo = Instantiate(HitEffect, _hit.point, Quaternion.LookRotation(_hit.normal));
            Destroy(ImpactGo, 1f);

           


        }

    }


     IEnumerator Reload()

    {




        Audio.clip = ReloadMusic;
        Audio.Play();

        Isreloading = true;


       

        Debug.Log("Reloading");

        

        Animator.SetBool("Reloading", true);

     

        

        yield return new WaitForSeconds(ReloadTime);

        Animator.SetBool("Reloading", false);

        CurrentAmmo = MaxAmmo;
        Ammo.text = MaxAmmo.ToString();

        Isreloading = false;
           


    }


}
