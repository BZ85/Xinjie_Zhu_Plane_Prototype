﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 0.5f;
    private float rotationSpeed = 100f;
    public float verticalInput = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate( Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(-1.0f * verticalInput * Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
