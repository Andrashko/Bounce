﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
 
    private Vector3 StartPos;
    private Rigidbody rb;
    public bool isDying = false;
    public void Kill()
    {
        print("You are ded");
        isDying = true;     
    }


    void Start()
    {
        StartPos = transform.position;
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (isDying)
        {
            transform.localScale -= Time.deltaTime * Vector3.one;
            if (transform.localScale.sqrMagnitude < 0.01)
            {
                isDying = false;
                transform.position = StartPos;
                transform.localScale = Vector3.one;
                print("You are dead!");
            }
        }
    }

}
