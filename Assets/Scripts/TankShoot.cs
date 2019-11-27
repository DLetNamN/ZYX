using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour
{


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void Shoot()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            Destroy(this.gameObject);
        }
    }
}
