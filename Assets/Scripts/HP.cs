using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AAT.HP
{
    public class HP : MonoBehaviour
    {
        //player identification
        [SerializeField] public int p_num;

        //player medical
        [SerializeField] public int p_hp;
        [SerializeField] int bul_dmg;

        [SerializeField] public string a_s_n;

        GameManagerScript game_mana;

        private void Start()
        {
            playerConfig();
        }

        private void playerConfig()
        {
            p_hp = 100;
            bul_dmg = 10;

            if (this.gameObject.name == "Player1")
            {
                p_num = 2;
            }
            else p_num = 1;

            a_s_n = "AAt_Shot " + p_num;
        }

        private void OnTriggerEnter(Collider collider)
        {
            if (collider.gameObject.name == a_s_n)
            {
                p_hp -= bul_dmg;
                Destroy(collider.gameObject);
            }
        }

        private void Update()
        {
            p_death();
        }

        void p_death() 
        { 
            if(p_hp <= 0)
            { /*Selects who won based upon which gameObject is dying. This happens a split second before the object is destroyed on scene.*/
                //if (this.gameObject.name == "Player1")
                //{
                //    game_mana.playerWhoWon = "Player2";
                //}
                //else game_mana.playerWhoWon = "Player1";

                Destroy(this.gameObject);
            }
        }

    }

}