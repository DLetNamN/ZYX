using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float Force;
    public GameObject bullet;
    private Animator anim;


    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetButton("Shoot"))
        {
            anim.SetBool("shoot", true);
            Force = 60;
        }
        else
        {
            //anim.SetBool("shoot", false);
            Force = 1;
        }

    }
}
