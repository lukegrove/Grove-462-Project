using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    public float spiderDamage = 10.0f;
    public GameObject bloodParticle = null;
    public HealthController _healthController = null;
    public AudioClip spiderAudio = null;

    private bool playingAudio;
    private AudioSource spiderAudioSource;

    private void Start()
    {
        spiderAudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bloodParticle.SetActive(true);
            spiderAudioSource.PlayOneShot(spiderAudio);
            _healthController.currentPlayerHealth -= spiderDamage;
            _healthController.TakeDamage();
            gameObject.GetComponent<BoxCollider>().enabled = false;
            playingAudio = true;
        }
    }

    private void Update()
    {
        if (playingAudio)
        {
            if (!spiderAudioSource.isPlaying)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
