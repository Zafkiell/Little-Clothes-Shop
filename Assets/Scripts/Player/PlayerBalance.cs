using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBalance : MonoBehaviour
{
    public int playerBalance;

    public TextMeshProUGUI playerBalanceText;

    void Start()
    {
        playerBalanceText.text = playerBalance.ToString();
    }
    
    public void UpdateBalance(int value)
    {
        playerBalance += value;
        playerBalanceText.text = playerBalance.ToString();
    }
}
