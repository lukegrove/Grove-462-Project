using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    [Header("Button Settings")]
    public Button retryButton;
    public string level;
    public Button menuButton;
    public string mainMenu;

    public void Level()
    {
        SceneManager.LoadScene(level);
        Debug.Log("Level loaded!");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenu);
        Debug.Log("Main menu loaded!");
    }
}
