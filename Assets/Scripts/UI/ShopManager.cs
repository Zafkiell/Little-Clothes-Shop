using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public GameObject confirmPanel;

    
    
    public void SwitchConfirmPanel()
    {
        confirmPanel.SetActive(!confirmPanel.activeSelf);
    }
}
