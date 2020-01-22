using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    //player identification
    int p_int;
    string p_t_name;

    //player medical
    [SerializeField] int p_hp;
    [SerializeField] int p_dmg;

    private void Start()
    {
        p_t_name = this.gameObject.tag;
        p_int = p_t_name[6];

        if (p_int != 1)
        {
            p_int -= 1;
        } 
        else
        {
            p_int += 1;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "AAt_Shot " + p_int)
        {
            p_hp -= p_dmg; 
        }
    }

    private void Update()
    {
        deathConditions();
    }

    private void deathConditions()
    {
        if(p_hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
