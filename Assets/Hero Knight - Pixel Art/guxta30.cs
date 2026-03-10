using System;
using UnityEngine;

public class guxta30 : MonoBehaviour
{
    private float speed = 5f;
    private float jumpForce = 5f;
    private float direçao;
    private Rigidbody rb;
    private bool isjumping; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = Getcomponent<Rigidbody>();
        isjumping = false;
    }

    private T Getcomponent<T>()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        direçao = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(direçao * speed, rb.linearVelocity.y);

        if (Input.GetButtonDown("jump") && isjumping == false) ;
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, jumpForce);
            isjumping = true;
        }
}
}
