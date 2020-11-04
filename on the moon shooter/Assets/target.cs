
using System.Collections;
using System.Linq.Expressions;
using UnityEngine;

public class target : MonoBehaviour
{
    public float heath = 25f;

    
    float delay = 1.6f;
    bool effectPlayed = false;
    private void Start()
    {
       
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

        

        Destroy(gameObject);
    }

}
