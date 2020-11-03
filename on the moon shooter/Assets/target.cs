
using System.Linq.Expressions;
using UnityEngine;

public class target : MonoBehaviour
{
    public float heath = 25f;

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
