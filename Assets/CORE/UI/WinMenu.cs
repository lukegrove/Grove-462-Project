using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    [Header("Button Settings")]
    public Button menuButton;
    public string mainMenu;

    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenu);
        Debug.Log("Main menu loaded!");
    }
}
