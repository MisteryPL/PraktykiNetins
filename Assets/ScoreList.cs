using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreList : MonoBehaviour {


    public GameObject playerScoreEntryPrefab;

    AddHighscore scoreManager;

	// Use this for initialization
	void Start () {
         
        scoreManager = GameObject.FindObjectOfType<AddHighscore>();

    

    }
	
	
	// Update is called once per frame
	void Update () {


        while(this.transform.childCount >0)
        {
            Transform c = this.transform.GetChild(0);
            c.SetParent(null);
            Destroy(c.gameObject);
        }

        string[] names = scoreManager.GetPlayerNames();

        foreach (string name in names)
        {
            GameObject go = (GameObject)Instantiate(playerScoreEntryPrefab);
            go.transform.SetParent(this.transform);
            go.transform.Find("Username").GetComponent<Text>().text = name;
            go.transform.Find("Score").GetComponent<Text>().text = scoreManager.GetScore(name).ToString();
        }
    }
}
