using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour {

    public float hp;
    public bool isEnemy = true;

    public void Damage(int damageCount)
    {

        hp -= damageCount;
        if (isEnemy == false)
        {
            Player_healthbar.health -= damageCount;
        }
        if(isEnemy == true)
        {
            CountScore.Score += 10;
            Enemy_healthbar.health -= damageCount;
        }

        if (hp <= 0)
        {
            Destroy(gameObject);

            if (isEnemy == false)
            {
                SceneManager.LoadScene("YouDied", LoadSceneMode.Single);
            }
            if (isEnemy == true)
            {
                SceneManager.LoadScene("YouWon", LoadSceneMode.Single);
                
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        ShotScript shot = otherCollider.gameObject.GetComponent<ShotScript>();
        if (shot != null)
        {
            if (shot.isEnemyShot != isEnemy)
            {
                Damage(shot.damage);
                Destroy(shot.gameObject);
            }
        }
    }

    private void Update()
    {
        if (isEnemy== false)
        {
            hp = Player_healthbar.health;
            if (hp >= 10f)
            {
                hp = 10f;
            }
        }
        if (isEnemy == true)
        {
            hp = Enemy_healthbar.health;
            if (hp >= 10f)
            {
                hp = 10f;
            }
        }
    }
}
