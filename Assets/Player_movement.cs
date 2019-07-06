using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player_movement : MonoBehaviour {

    public Vector2 speed = new Vector2(10, 10); //speed of player
    private Vector2 movement;
    private Rigidbody2D rigidbodyComponent;

    public bool isGrounded = true;



    private void Start()
    {
        rigidbodyComponent = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");

        movement = new Vector2(speed.x * inputX / 15, 0);

        bool jump = Input.GetKeyDown(KeyCode.W);

        if (jump)
        {
            if (isGrounded == true)
            {
                rigidbodyComponent.AddForce(new Vector2(speed.x * inputX/15, 4)*2000);
            }
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            if(Player_staminabar.stamina >= 5f)
            {
                Building1_healthbar.health += 3f;
                Player_healthbar.health += 2f;
                Player_staminabar.stamina = 0;
            }
        }
        

    }

    void FixedUpdate()
    {
        if (rigidbodyComponent == null)
        {
            rigidbodyComponent = GetComponent<Rigidbody2D>();
        }

        rigidbodyComponent.velocity = movement;
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
