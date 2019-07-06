using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building_script : MonoBehaviour {

    public static int health = 0;
    public float hp = 10f;
    public bool isEnemy = true;
    public bool isPlayerBuilding = false;
    public bool isEnemyBuilding = false;

    public void Damage(int damageCount)
    {
        hp -= damageCount;
        if (isPlayerBuilding == true)
        {
            Building1_healthbar.health -= damageCount;
        }
        
        if(isEnemyBuilding == true)
        {
            CountScore.Score += 5;
            Building2_healthbar.health -= damageCount;
        }
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
            Damage(shot.damage);
            Destroy(shot.gameObject);       
        }
    }
    private void Update()
    {
        if (isPlayerBuilding == true)
        {
            hp = Building1_healthbar.health;
            if(hp>=10f)
            {
                hp = 10f;
            }
        }
        if(isEnemyBuilding == true)
        {
            hp = Building2_healthbar.health;
            if (hp >= 10f)
            {
                hp = 10f;
            }
        }
    }
}
