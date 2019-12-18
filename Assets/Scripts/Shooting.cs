using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [Header("Gameobjects")]
    public GameObject bulletObject;

    [Header("Charging")]
    [SerializeField] float chargeTime;
    [SerializeField] float forceMultiplier;

    [Header("Animations and Sounds")]
    [SerializeField] AudioSource chargeSound;
    [SerializeField] Animator chargingAnim;

    [Header("Transforms")]
    public Transform bulletSpawnpoint;

    // Update is called once per frame
    void Update()
    {
        chargeTime = Mathf.Clamp(chargeTime, 0, 3);

        if (Input.GetButtonDown("Fire1"))
        {
            chargeSound.Play();
        }

        if (Input.GetButton("Fire1"))
        {
            chargeSound.pitch = 1;

            chargeTime += Time.deltaTime;
            chargeSound.pitch = chargeTime;
        }

        if (Input.GetButtonUp("Fire1"))
        {
            Instantiate(bulletObject, bulletSpawnpoint.position, Quaternion.identity);

            chargeTime = 0;
            chargeSound.Stop();
        }
    }
}
