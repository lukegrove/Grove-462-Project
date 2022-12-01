using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public float currentPlayerHealth = 100.0f;
    public float maxPlayerHealth = 100.0f;

    private bool canRegen = false;
    private bool startCooldown = false;
    public float healCooldown = 3.0f;
    public float maxHealCooldown = 3.0f;
    public float regenRate = 1;
    public float hurtTimer = 0.1f;

    public Image splatter = null;
    public Image radial = null;

    public AudioClip hurtAudio = null;
    private AudioSource healthAudioSource;

    public GameObject failedUI;
    
    private void Start()
    {
        failedUI.SetActive(false);
        healthAudioSource = GetComponent<AudioSource>();
    }

    public void UpdateHealth()
    {
        Color splatterAlpha = splatter.color;
        splatterAlpha.a = 1 - (currentPlayerHealth / maxPlayerHealth);
        splatter.color = splatterAlpha;
    }

    IEnumerator HurtFlash()
    {
        radial.enabled = true;
        healthAudioSource.PlayOneShot(hurtAudio);
        yield return new WaitForSeconds(hurtTimer);
        radial.enabled = false;
    }

    public void TakeDamage()
    {
        if (currentPlayerHealth >= 0)
        {
            canRegen = false;
            StartCoroutine(HurtFlash());
            UpdateHealth();
            healCooldown = maxHealCooldown;
            startCooldown = true;
        }
        if (currentPlayerHealth == 0)
        {
            failedUI.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (startCooldown)
        {
            healCooldown -= Time.deltaTime;
            if (healCooldown <= 0)
            {
                canRegen = true;
                startCooldown = false;
            }
        }

        if (canRegen)
        {
            if (currentPlayerHealth <= maxPlayerHealth - 0.01)
            {
                currentPlayerHealth += Time.deltaTime * regenRate;
                UpdateHealth();
            }
            else
            {
                currentPlayerHealth = maxPlayerHealth;
                healCooldown = maxHealCooldown;
                canRegen = false;
            }
        }
    }
}
