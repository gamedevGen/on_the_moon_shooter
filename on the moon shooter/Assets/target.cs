
using System.Linq.Expressions;
using UnityEngine;

public class target : MonoBehaviour
{
    public float heath = 25f;
    public ParticleSystem dead;
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
        Destroy(gameObject);
    }
}
