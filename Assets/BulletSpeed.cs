using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeed : MonoBehaviour
{
    private Rigidbody rb;

    public GameObject explosionObject;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        GameObject player = GameObject.FindWithTag("Player");
        Shooting shoot = player.GetComponent<Shooting>();

        rb.velocity = transform.forward * shoot.forceMultiplier * 1000;
    }

    private void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.tag == "Wall")
        {
            Instantiate(explosionObject);
            Destroy(gameObject);
        }
    }
}
