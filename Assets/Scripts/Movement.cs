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
        if (gameObject.tag == "Player1")
            Player1Thrust();

        if (gameObject.tag == "Player2")
            Player2Thrust();
    }

    void Player1Thrust()
    {
        if (Input.GetButton("Thrust"))
        {
            rb.AddForce(moveSpeed * transform.forward, ForceMode.Acceleration);
        }

        ct.Rotate(Vector3.up, rotationSpeed * Input.GetAxis("Horizontal1"));
    }

    void Player2Thrust()
    {
        if (Input.GetButton("Thrust2"))
        {
            rb.AddForce(moveSpeed * transform.forward, ForceMode.Acceleration);
        }

        ct.Rotate(Vector3.up, rotationSpeed * Input.GetAxis("Horizontal2"));
    }
}
