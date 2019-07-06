using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_script : MonoBehaviour {

    private Weapon_script[] weapons;
    private Weapon_script2[] weapons2;

    private void Awake()
    {
        weapons = GetComponentsInChildren<Weapon_script>();
        weapons2 = GetComponentsInChildren<Weapon_script2>();
    }

    void Update ()
    {

        foreach (Weapon_script weapon in weapons)
        {
            if (weapon != null && weapon.CanAttack)
            {

                weapon.Attack(true);
            }
        }

        foreach (Weapon_script2 weapon2 in weapons2)
        {
            if (weapon2 != null)
            {
 
                weapon2.Attack(true);
            }
        }
    }
}
