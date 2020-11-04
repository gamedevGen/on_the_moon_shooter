
using System.Collections;
using System.Linq.Expressions;
using UnityEngine;

public class target : MonoBehaviour
{
    public float heath = 25f;
<<<<<<< HEAD
    public ParticleSystem dead;
    float delay = 1.6f;
    bool effectPlayed = false;
    private void Start()
    {
        dead.Stop();
    }
=======

>>>>>>> parent of 5c6e23a... effects
    public void Takedamge (float amount)
    {
        heath -= amount;
        if(heath <= 0f)
        {
            die();
           

        }
       
    }
    void die()
    {
<<<<<<< HEAD
        dead.Play();
        StartCoroutine((string)effectDelay());
        
=======
>>>>>>> parent of 5c6e23a... effects
        Destroy(gameObject);
    }
    IEnumerable effectDelay()
    {
        yield return new WaitForSeconds(1.8f);

    }
}
