using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playrmovemit : MonoBehaviour
{
    public CharacterController contterol;

    public float speed = 12f;
    public float gravity = -9.81f;
    public Transform groundcack;
    public float groundfar = 0.4f;
    public LayerMask groundmask;
    bool isgrounded;
    public float jumpHeight = 3f;


    Vector3 velocity;

    // Update is called once per frame
    void Update()
    {
        isgrounded = Physics.CheckSphere(groundcack.position, groundfar, groundmask);
        if (isgrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        if(Input.GetButtonDown("Jump") && isgrounded)
        {

            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }
        contterol.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        contterol.Move(velocity * Time.deltaTime);

    }
}
