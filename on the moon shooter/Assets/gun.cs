using System;
using UnityEngine;

public class gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera fpscam;
    public ParticleSystem laserShoot;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
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
        }
    }
}
