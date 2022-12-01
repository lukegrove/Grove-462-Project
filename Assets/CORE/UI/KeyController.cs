using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyController : MonoBehaviour
{
    public bool canWin;

    public AudioClip keyAudio = null;
    private AudioSource keyAudioSource;

    public GameObject progressDoor;
    public GameObject victorySpaceship;

    public GameObject winUI;
    
    private void Start()
    {
        winUI.SetActive(false);
        keyAudioSource = GetComponent<AudioSource>();
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
            winUI.SetActive(true);
        }
    }
}
