using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    float hp_p1, hp_p2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "AAt_Shot")
        {

        }
    }
}
