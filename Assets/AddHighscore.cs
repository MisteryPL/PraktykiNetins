using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class AddHighscore : MonoBehaviour /// Klasa tworząca słownik z rekordami
{
    public int score;
    private string value_of_name;

    Dictionary<string, int> playerScores;

    void Start()
    {
        score = PlayerPrefs.GetInt("Score");

         /* //// Przykłady na sztywno - powinny działać
                SetScore("elfen", 9001);
                SetScore("Eva", 71);

                SetScore("AAA", 76);
                SetScore("aa", 23);

                SetScore("BBB", 1);
                SetScore("B", 2); */
    }

    public void InputChanged(InputField _input)
    {
        string value = _input.text;
        value_of_name = value;

    }

    public void Save()
    {
        Init();
        SetScore(value_of_name, score);
    }

 
    void Init()
    {
        if (playerScores != null)
        {
            return;
        }
        playerScores = new Dictionary<string, int>();
    }

    public int GetScore(string username)
    {
        Init();
        if (playerScores.ContainsKey(username) == false)
        {
            return 0;
        }
        return playerScores[username];
    }

    public void SetScore(string username, int value)
    {
        Init();
        if (playerScores.ContainsKey(username) == false)
        {
            playerScores[username] = value;
        }
    }
    
    public string[] GetPlayerNames()
    {
        Init();
        return playerScores.Keys.OrderByDescending(n => GetScore(n)).ToArray();
    }
}
 
