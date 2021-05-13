using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
    public float damage = 20f;
    public float fireRate = 3f;
    public float force = 155f;
    public float range = 15f;
    public ParticleSystem muzzleFlash;
    public Transform bulletSpawn;
    public AudioClip shotSFX;
    public AudioSource audioSource;
    public static Vector3 pos;
    // public GameObject hitEffekt;
    public Rigidbody pulyaTelo;
    public Camera cam;
    private float nextFire = 0f;
    public Button buttonFire;
    private bool fire = false;
   
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Shoot()
    {
        fire = true;
    }

    public void ShootStop ()
    {
        fire = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        pos = transform.position;

        

        if (AutoFire.autoFire == true)
        {
            RaycastHit hit;

            if (Physics.Raycast(cam.transform.position,cam.transform.forward,out hit,range) && hit.rigidbody != null && Time.time > nextFire)
            {
                nextFire = Time.time + 1f / fireRate;
                audioSource.PlayOneShot(shotSFX);
                muzzleFlash.Play();
                //GameObject impact = Instantiate(hitEffekt, hit.point, Quaternion.LookRotation(hit.normal));
                //Destroy(impact, 2f);
                hit.rigidbody.AddForce(-hit.normal * force);
                Rigidbody pulya = Instantiate(pulyaTelo, cam.transform.position, cam.transform.rotation);
                pulya.velocity = transform.TransformDirection(Vector3.forward * 100);   // 100 - speed pulya
                               
            }
        }

        if (fire == true)
        {
            RaycastHit hit;

            if (Time.time > nextFire)
            {
                nextFire = Time.time + 1f / fireRate;
                audioSource.PlayOneShot(shotSFX);
                muzzleFlash.Play();
                Rigidbody pulya = Instantiate(pulyaTelo, cam.transform.position, cam.transform.rotation);
                pulya.velocity = transform.TransformDirection(Vector3.forward * 100);

                if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
                {

                }
                //switch (hit.collider.tag)
                //{ 
                //    case "Arm_L":
                //        //Destroy(gameObject.tag = "Arm_L");
                //        break;
                //}
            }
        }

        //else
        //{
        //    buttonFire.onClick.AddListener(Shoot);
        //}

        
        
    }

    
}
