using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_left_cooldown : MonoBehaviour {

    Image cooldownBar;
    public static float maxCooldown = 0;
    public static float cooldown;

    void Start()
    {
        cooldownBar = GetComponent<Image>();
        cooldownBar.fillAmount = 0f;
        
    }

    
    void Update()
    {
        if (cooldown < maxCooldown)
        {
            cooldown += Time.deltaTime;
            cooldownBar.fillAmount = cooldown / maxCooldown;
        }    

        if (cooldown >= maxCooldown)
        {
            
            cooldown = 0;
            maxCooldown = 0;
            cooldownBar.fillAmount = 0;
        }
    }
}
