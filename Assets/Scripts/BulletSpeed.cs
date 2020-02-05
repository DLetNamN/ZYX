using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AAT.Combat;

public class BulletSpeed : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] string player_n;

    private void GetPlayer()
    {
        if (gameObject.name == "AAt_Shot 1(Clone)")
        {
            player_n = "Player1";
        }
        else player_n = "Player2";
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        GetPlayer();

    }

    // Update is called once per frame
    void Update()
    {
        callShotForce();
    }

    void callShotForce()
    {
        rb.AddForce(GameObject.FindWithTag(player_n).GetComponent<Shoot>().Force * transform.forward * 25, ForceMode.Impulse);
    }
}
