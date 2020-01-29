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
            Force *= Time.deltaTime * 60;
        }
        else
        {
            anim.SetBool("shoot", false);
            Force = 1;
        }

        if (Input.GetButtonUp("Shoot"))
        {
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + 3, transform.position.z), Quaternion.identity);
        }
    }
}
