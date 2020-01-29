using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    //player identification
    [SerializeField] int p_int;
    string p_t_name;

    //player medical
    [SerializeField] int p_hp;
    [SerializeField] int p_dmg;

    public string a_s_n;

    private void Start()
    {
        playerConfig();
    }

    private void playerConfig()
    {
        p_t_name = this.gameObject.tag;

        if (p_int != 1)
        {
            p_int -= 1;
        }
        else
        {
            p_int += 1;
        }

        a_s_n = "AAt_Shot " + p_int;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == a_s_n)
        {
            p_hp -= p_dmg; 
        }
    }

    private void Update()
    {
        
    }

}
