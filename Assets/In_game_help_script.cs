using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class In_game_help_script : MonoBehaviour {

    public Image help_image;
    public bool isImageOn;

	// Use this for initialization
	void Start () {
        help_image.enabled = false;
        isImageOn = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.H))
        {
            if(isImageOn == false)
            {
                help_image.enabled = true;
                isImageOn = true;
            }
            else
            {
                help_image.enabled = false;
                isImageOn = false;
            }
        }
	}
}
