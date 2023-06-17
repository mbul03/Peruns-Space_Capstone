using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void playGame()
	{
		SceneManager.LoadScene("Game");
	}
    public void ExitGame()
    {
        Application.Quit();
    }
    public void BackToMenu() {
        SceneManager.LoadScene("Main Menu");
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("How to Play");
    }
}
