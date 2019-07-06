using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour {

    public Text score_text;
    private int max_score;

    public void Start()
    {
        max_score = PlayerPrefs.GetInt("Score");
        score_text.text = "Score \n" + max_score.ToString();
    }
}
