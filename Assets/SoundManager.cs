using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public static AudioClip shootingSound, winSound, loseSound, birdSound, golfSound;
    static AudioSource audioSrc;


	// Use this for initialization
	void Start () {

        shootingSound = Resources.Load<AudioClip>("throwing_sound");
        winSound = Resources.Load<AudioClip>("victory");
        loseSound = Resources.Load<AudioClip>("defeat");
        birdSound = Resources.Load<AudioClip>("bird");
        golfSound = Resources.Load<AudioClip>("golf");

        audioSrc = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void PlaySound(string clip)
    {
        switch(clip)
        {
            case "shoot":
                audioSrc.PlayOneShot(shootingSound);
                break;
            case "victory":
                audioSrc.PlayOneShot(winSound);
                break;
            case "defeat":
                audioSrc.PlayOneShot(loseSound);
                break;
            case "bird":
                audioSrc.PlayOneShot(birdSound);
                break;
            case "golf":
                audioSrc.PlayOneShot(golfSound);
                break;
        }
    }
}
