using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_staminabar : MonoBehaviour {

    Image staminaBar;
    float maxStamina = 5f;
    public static float stamina;


    // Use this for initialization
    void Start()
    {
        staminaBar = GetComponent<Image>();
        stamina = 0;
    }

    // Update is called once per frame
    void Update()
    {
        staminaBar.fillAmount = stamina / maxStamina;
    }
}
