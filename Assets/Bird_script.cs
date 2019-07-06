using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_script : MonoBehaviour {

    public int hp = 1;
    public bool isEnemy = true;

    public void Damage(int damageCount)
    {
        hp -= damageCount;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
        if (shot != null)
        {
            if(shot.isEnemyShot == false)
            {
                Player_staminabar.stamina += 1f;
                CountScore.Score++;
            }
            if(shot.isEnemyShot == true)
            {
                Enemy_staminabar.stamina += 1f;
            }

            SoundManager.PlaySound("bird");
            Damage(shot.damage);
            Destroy(shot.gameObject);     
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
