using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy_movement : MonoBehaviour {

    public Vector2 speed = new Vector2(10, 10); //speed of player

    private Rigidbody2D rigidbodyComponent;

    public bool isGrounded = true;

    private void Start()
    {
        rigidbodyComponent = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {

            if (isGrounded == true)
            {
                rigidbodyComponent.AddForce(new Vector2(Random.Range(-0.2f, 0.2f), 1) * 1500);
            }
        
            if (Enemy_staminabar.stamina >= 5f)
            {
                Building2_healthbar.health += 3f;
                Enemy_staminabar.stamina = 0;
            }
        

    }

    void FixedUpdate()
    {
        if (rigidbodyComponent == null)
        {
            rigidbodyComponent = GetComponent<Rigidbody2D>();
        }

        rigidbodyComponent.velocity = new Vector2(0,0);
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }

}
