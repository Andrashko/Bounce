using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public float Speed = 3f;
    public float JumpSpeed = 9f;
    public bool isJumpig = false;
    private Rigidbody rb;
    private float eps = 0.0001f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   
    void Update()
    {

        transform.Translate(Input.GetAxis("Vertical") * Speed * Time.deltaTime,0,0);
        transform.Translate(0,0,-Input.GetAxis("Horizontal") * Speed * Time.deltaTime);
        if (Input.GetButtonDown("Jump") && !isJumpig)
        {
            isJumpig = true;
            rb.AddForce(0, JumpSpeed, 0, ForceMode.Impulse);
        }
        else if (Math.Abs(rb.velocity.y) < eps)
        {
            isJumpig = false;
        }
    }
}
