using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public GameObject confirmPanel;
    public GameObject lockClickPanel;
    public GameObject itemPrefab;
    GameObject itemInstance;
    public Transform itemStartPos;

    [HideInInspector] public int currentItemPrice;
    [HideInInspector] public ItemSO currentItemSO;

    public PlayerBalance playerBalance;
    public TextMeshProUGUI confirmPanelText;


    public void GetCurrentButton(Button button)
    {
        confirmPanel.SetActive(true);
        lockClickPanel.SetActive(true);

        currentItemPrice = button.GetComponent<ShopButton>().price;
        currentItemSO = button.GetComponent<ShopButton>().buttonItem;
    }

    public void ConfirmPurchase()
    {
        if(playerBalance.playerBalance >= currentItemPrice)
        {
            confirmPanel.SetActive(false);
            lockClickPanel.SetActive(false);

            playerBalance.UpdateBalance(-currentItemPrice);

            //Intance item on mouse position
            InstanceItem();
        }
        else
        {
            confirmPanelText.text = "Not Enough Money";
            Invoke("TurnOffNoMoney", 5f);
        }
    }

    void InstanceItem()
    {
        itemInstance = Instantiate(itemPrefab, itemStartPos.position,Quaternion.identity);
        itemInstance.transform.parent = GetComponentInParent<Canvas>().transform;
        itemInstance.transform.localScale = new Vector3(1.4f,1.4f,1f);
        itemInstance.GetComponent<Item>().itemSO = currentItemSO;
        itemInstance.GetComponent<DragDrop>().canvas = GetComponentInParent<Canvas>();
    }

    void TurnOffNoMoney() => confirmPanelText.text = "Buy this item";

    public void CancelPurchase()
    {
        confirmPanel.SetActive(false);
        lockClickPanel.SetActive(false);

        confirmPanelText.text = "Buy this item";

        currentItemPrice = 0;
        currentItemSO = null;
    }
}
