using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_script2 : MonoBehaviour {
    public Transform shotPrefab;
    public float shootingRate = 0.25f;
    private float shootCooldown;
    public bool isBird;

    public bool isPlayerWeapon;

    void Start()
    {
        shootCooldown = 0f;
        if (isPlayerWeapon == true)
        {
            Player_script.whatCooldown2 = shootingRate;
        }
    }

    void Update()
    {
        if (shootCooldown > 0)
        {
            
            shootCooldown -= Time.deltaTime;
        }
    }


    public void Attack(bool isEnemy)
    {
        if (CanAttack)
        {
            shootCooldown = shootingRate;


            // Create a new shot
            var shotTransform = Instantiate(shotPrefab) as Transform;

            // Assign position
            shotTransform.position = transform.position;

            // The is enemy property
            ShotScript shot = shotTransform.gameObject.GetComponent<ShotScript>();
            if (shot != null)
            {
                if (isPlayerWeapon == false)
                {
                    SoundManager.PlaySound("golf");
                }
                if(isPlayerWeapon == true)
                {
                    SoundManager.PlaySound("shoot");
                }
                shot.isEnemyShot = isEnemy;
            }

            // Make the weapon shot always towards it
            Move_script move = shotTransform.gameObject.GetComponent<Move_script>();
            if (move != null)
            {
                move.direction = this.transform.right; // towards in 2D space is the right of the sprite
            }
        }
    }

    public bool CanAttack
    {
        get
        {
            return shootCooldown <= 0f;
        }
    }
}
