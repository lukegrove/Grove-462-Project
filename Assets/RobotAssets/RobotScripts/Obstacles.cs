using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public bool isFailed;
    public bool isWin;

    private void Start()
    {
        isFailed = false;
        isWin = false;
    }

    private void Update()
    {
        if (isFailed == true)
        { 
            RobotUI.instance.failedUI.SetActive(true);
        }
        if (isWin == true)
        { 
            RobotUI.instance.WinUI.SetActive(true);
        }
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            isFailed = true;
        }
        if (collision.gameObject.name == "Win")
        {
            isWin = true;
        }
    }
}
