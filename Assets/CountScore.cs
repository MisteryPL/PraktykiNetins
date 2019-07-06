using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScore : MonoBehaviour {

    public static int Score;
    public Text score_text;
    private int max_score;


    void Update () {
        max_score += Score;
        Score = 0;
        PlayerPrefs.SetInt("Score", max_score);
        score_text.text = "Score \n" + max_score.ToString();
	}
}
