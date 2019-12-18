using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletObject;

    [SerializeField] float chargeTime;
    [SerializeField] float forceMultiplier;

    [SerializeField] AudioSource chargeSound;
    [SerializeField] Animator chargingAnim;

    public Transform bulletSpawnpoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            chargeTime += Time.deltaTime;
            chargeSound.pitch = chargeTime;
        }

        if (Input.GetButtonUp("Fire1"))
        {
            Instantiate(bulletObject, bulletSpawnpoint.position, Quaternion.identity);
        }
    }
}
