
using System.Collections;
using System.Linq.Expressions;
using UnityEngine;

public class target : MonoBehaviour
{
    public float heath = 25f;

    public ParticleSystem dead;
    float delay = 1.6f;
    bool effectPlayed = false;
    private void Start()
    {
        dead.Stop();
    }

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

        dead.Play();
        StartCoroutine((string)effectDelay());
        

        Destroy(gameObject);
    }
    IEnumerable effectDelay()
    {
        yield return new WaitForSeconds(1.8f);

    }
}
