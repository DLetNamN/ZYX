using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;


    //variables
    public float moveSpeed = 5;
    public float rotationSpeed = 10;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetButton("Thrust"))
        {
            rb.AddForce(moveSpeed * transform.forward, ForceMode.Acceleration);
        }

        transform.Rotate(Vector3.up, 3 * Input.GetAxis("Horizontal"));
    }
}
