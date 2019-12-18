using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float Force;
    public GameObject bullet;

    void Update()
    {
        if (Input.GetButton("Shoot"))
        {
            Force *= Time.deltaTime;
        }

        if (Input.GetButtonUp("Shoot"))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
}
