using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_Script : MonoBehaviour {

    public Image help_image;
    public Text cut_scene_text;
    public Image button_image;
    public Button zagraj;
    public Text button_text;

    void Start()
    {
        help_image.enabled = false;
        cut_scene_text.enabled = false;
        button_image.enabled = false;
        zagraj.enabled = false;
        button_text.enabled = false;
    }

    public void StartGame ()
    {
        SceneManager.LoadScene("City", LoadSceneMode.Single);
	}

    public void QuitGame ()
    {
        Application.Quit();
    }
	
	public void Menu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void Highscores()
    {
        SceneManager.LoadScene("Highscores", LoadSceneMode.Single);
    }

    public void LoadCutScene()
    {
        help_image.enabled = true;
        cut_scene_text.enabled = true;
        button_image.enabled = true;
        zagraj.enabled = true;
        button_text.enabled = true;
    }
}
