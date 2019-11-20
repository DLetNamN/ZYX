using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;


    //variables
    public float moveSpeed = 5;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Thrust"))
        {
            rb.velocity = transform.forward * moveSpeed;
        }


    }
}
