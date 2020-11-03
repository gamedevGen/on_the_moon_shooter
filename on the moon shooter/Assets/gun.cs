using System;
using UnityEngine;

public class gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera fpscam;
    public ParticleSystem laserShoot;
    public GameObject inpactEffect;
    public float fore = 25f;
    public float fire = 15f;


    private float nexttimetofire = 0f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nexttimetofire)
        {
            nexttimetofire = Time.time + 1f / fire;
            shoot();
        }

        
    }

    void shoot ()
    {
        laserShoot.Play();
        RaycastHit hi;
        if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hi, range))
        {
            Debug.Log(hi.transform.name);
           target Target = hi.transform.GetComponent<target>();
            if (Target != null)
            {
                Target.Takedamge(damage);
            }
            if (hi.rigidbody != null)
            {
                hi.rigidbody.AddForce(-hi.normal * fore);
            }
            GameObject inpct = Instantiate(inpactEffect, hi.point, Quaternion.LookRotation(hi.normal));
            Destroy(inpct, 1f);
        }
    }
}
