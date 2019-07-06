using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim_script_Enemy : MonoBehaviour {

    private Rigidbody2D rigidbodyComponent;
    private Vector3 target;
    GameObject player1;

    private void Start()
    {
        target = transform.position;
    }

    void Update()
    {

        target = GameObject.Find("Player1_sprite").transform.position;
        target.z = transform.position.z;

        transform.position = Vector3.MoveTowards(transform.position, target, 1);

        /* //obracanie celownika wokół postaci w kierunku kursora myszki
        
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotation_speed * Time.deltaTime);
        */
    }

}
