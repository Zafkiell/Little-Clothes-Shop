using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventory : MonoBehaviour
{
    public GameObject playerInventory;
    public GameObject playerEquipPanel;

    public void SwitchBag()
    {
        playerInventory.SetActive(!playerInventory.activeSelf);
        playerEquipPanel.SetActive(!playerEquipPanel.activeSelf);
    }
}
