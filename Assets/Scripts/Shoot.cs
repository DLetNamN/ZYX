using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float Force;
    public GameObject bullet;

    public Transform bulletSpawnpoint;

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Force *= Time.deltaTime;
        }

        if (Input.GetButtonUp("Fire1"))
        {
            Instantiate(bullet, bulletSpawnpoint.position, Quaternion.identity);
        }
    }
}
