using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyController : MonoBehaviour
{
    public bool canWin;

    public AudioSource audioSource;

    public GameObject progressDoor;
    public GameObject victorySpaceship;

    public GameObject winUI;
    
    private void Start()
    {
        winUI.SetActive(false);
        canWin = false;
    }

    private void Update()
    {
        if (canWin == true)
        {
            progressDoor.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Victory" & canWin == true)
        {
            gameObject.SetActive(false);
            audioSource.Play();
            winUI.SetActive(true);
        }
    }
}
