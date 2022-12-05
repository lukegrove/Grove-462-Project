using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [Header("Button Settings")]
    public Button startButton;
    public string pauseMenu;

    public void PauseMenu()
    {
        SceneManager.LoadScene(pauseMenu);
        Debug.Log("Pause menu loaded!");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exiting application...");
    }
}
