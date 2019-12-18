using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private Transform ct;

    //variables
    public float moveSpeed = 50;
    public float rotationSpeed = 10;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ct = GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.GetButton("Thrust"))
        {
            rb.AddForce(moveSpeed * transform.forward, ForceMode.Acceleration);
        }

        ct.Rotate(Vector3.up, rotationSpeed * Input.GetAxis("Horizontal"));
    }
}
