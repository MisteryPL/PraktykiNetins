﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_script : MonoBehaviour {

    public Vector2 speed = new Vector2(10, 10);

    public Vector2 direction = new Vector2(-1, 0);

    private Vector2 movement;
    private Rigidbody2D rigidbodyComponent;

    void Update ()
    {
        movement = new Vector2(speed.x * direction.x / 5, speed.y * direction.y / 5);  
	}

    private void FixedUpdate()
    {
        if(rigidbodyComponent == null)
        {
            rigidbodyComponent = GetComponent<Rigidbody2D>();
        }

        rigidbodyComponent.velocity = movement;
    }
}
