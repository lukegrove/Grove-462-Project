using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyController : MonoBehaviour
{
    private bool canWin = false;
    private bool key1 = false;
    private bool key2 = false;
    private bool key3 = false;
    private bool key4 = false;
    private int keyCounter = 0;

    public Image keyImage1 = null;
    public Image keyImage2 = null;
    public Image keyImage3 = null;
    public Image keyImage4 = null;

    public AudioClip keyAudio = null;
    private AudioSource keyAudioSource;

    public GameObject winUI;
    
    private void Start()
    {
        winUI.SetActive(false);
        keyAudioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        //
    }
}
