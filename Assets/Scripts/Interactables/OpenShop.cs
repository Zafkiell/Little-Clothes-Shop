using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShop : MonoBehaviour
{
    public GameObject shopPanel;
    public GameObject playerInventory;

    public GameObject keyPopUp;

    PlayerMovement playerMovement;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        keyPopUp.SetActive(true);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                shopPanel.SetActive(true);
                playerInventory.SetActive(true);
                keyPopUp.SetActive(false);

                playerMovement = collision.gameObject.GetComponent<PlayerMovement>();
                playerMovement.enabled = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        keyPopUp.SetActive(false);
    }

    public void CloseShop()
    {
        shopPanel.SetActive(false);
        playerInventory.SetActive(false);
        playerMovement.enabled = true;
    }
}
