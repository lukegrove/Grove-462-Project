using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotUI : MonoBehaviour
{
    public GameObject failedUI;
    public GameObject WinUI;

    public static RobotUI instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        failedUI.SetActive(false);
        WinUI.SetActive(false);
    }
}
