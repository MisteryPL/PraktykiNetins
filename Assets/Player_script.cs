using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_script : MonoBehaviour {

    private Weapon_script[] weapons;
    private Weapon_script2[] weapons2;

    public static float whatCooldown1;
    public static float whatCooldown2;

    private void Awake()
    {
        weapons = GetComponentsInChildren<Weapon_script>();
        weapons2 = GetComponentsInChildren<Weapon_script2>();

    }

    void Update ()
    {
        bool shoot1 = Input.GetKeyDown(KeyCode.Mouse0);
        bool shoot2 = Input.GetKeyDown(KeyCode.Mouse1);


        if (shoot1 && (Player_left_cooldown.cooldown == 0))
        {
            Player_left_cooldown.maxCooldown = whatCooldown1;
         
            foreach (Weapon_script weapon in weapons)
            {
                if (weapon != null)
                {
                    weapon.Attack(false);
                }
            }
        }

        if (shoot2 && (Player_right_cooldown.cooldown == 0))
        {
            Player_right_cooldown.maxCooldown = whatCooldown2;
      
            foreach (Weapon_script2 weapon2 in weapons2)
            {
                if (weapon2 != null)
                {
                    weapon2.Attack(false);
                }
            }
        }

    }
}
