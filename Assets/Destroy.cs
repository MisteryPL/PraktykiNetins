using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour {



    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("GameObject Hit: " + collision.gameObject.name);
        if (collision.gameObject.name == "Player1_sprite")
        {
            SoundManager.PlaySound("defeat");
            SceneManager.LoadScene("YouDied", LoadSceneMode.Single);
        }
        if (collision.gameObject.name == "Player2_golf")
        {
            SoundManager.PlaySound("victory");
            SceneManager.LoadScene("YouWon", LoadSceneMode.Single);
        }

    }
    
}
