using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level_1");
    }
	public void GoToSettings()
    {
        SceneManager.LoadScene("SettingsMenu");
    }
	public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
	public void ExitGame()
	{
		Application.Quit();
	}

    public void StartAgain()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Level_2");
    }

}
