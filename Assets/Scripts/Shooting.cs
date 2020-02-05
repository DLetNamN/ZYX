using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AAT.Combat
{
    public class Shooting : MonoBehaviour
    {
        [Header("Gameobjects")]
        public GameObject bulletObject;

        [Header("Charging")]
        [SerializeField] float chargeTime;
        public float forceMultiplier;

        [Header("Animations and Sounds")]
        [SerializeField] AudioSource chargeSound;
        [SerializeField] AudioSource blastSound;
        [SerializeField] Animator chargingAnim;

        [Header("Transforms")]
        public Transform bulletSpawnpoint;

        public int transformForceMultiplier = 15;

        // Update is called once per frame
        void Update()
        {
            Player1Shoot();
            Player2Shoot();
        }

        void Player1Shoot()
        {
            if (gameObject.tag == "Player1")
            {
                chargeTime = Mathf.Clamp(chargeTime, 0, 3);

                if (Input.GetButtonUp("Fire1"))
                {
                    Instantiate(bulletObject, bulletSpawnpoint.position, bulletSpawnpoint.rotation);

                    chargeTime = 0;
                    chargeSound.Stop();
                }

                if (Input.GetButtonDown("Fire1"))
                {
                    chargeSound.Play();
                }

                if (Input.GetButton("Fire1"))
                {
                    chargeSound.pitch = 1;

                    chargeTime += Time.deltaTime;
                    chargeSound.pitch = chargeTime;

                    forceMultiplier = chargeTime;
                }
            }
        }

        void Player2Shoot()
        {
            if (gameObject.tag == "Player2")
            {
                chargeTime = Mathf.Clamp(chargeTime, 0, 3);

                if (Input.GetButtonUp("Fire2"))
                {
                    Instantiate(bulletObject, bulletSpawnpoint.position, bulletSpawnpoint.rotation);

                    chargeTime = 0;
                    chargeSound.Stop();
                }

                if (Input.GetButtonDown("Fire2"))
                {
                    chargeSound.Play();
                }

                if (Input.GetButton("Fire2"))
                {
                    chargeSound.pitch = 1;

                    chargeTime += Time.deltaTime;
                    chargeSound.pitch = chargeTime;

                    forceMultiplier = chargeTime;
                }
            }
        }
    }

}