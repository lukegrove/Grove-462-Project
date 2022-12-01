using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();
        KeyController KeyController = other.GetComponent<KeyController>();

        if (playerInventory != null)
        {
            playerInventory.KeyCollected();
            gameObject.SetActive(false);
        }

        if (playerInventory.NumberOfKeys == 4)
        {
            KeyController.canWin = true;
        }
    }
}