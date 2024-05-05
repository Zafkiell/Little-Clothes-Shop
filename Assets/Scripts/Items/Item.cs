using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public ItemSO itemSO;
    Image itemImage;

    private void Start()
    {
        itemImage = GetComponent<Image>();
        itemImage.sprite = itemSO.itemSprite;
    }
}
