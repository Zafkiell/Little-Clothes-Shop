using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopButton : MonoBehaviour
{
    public ItemSO buttonItem;
    public int price;
    public TextMeshProUGUI priceText;

    private void Start()
    {
        priceText.text = price.ToString();
    }
}
