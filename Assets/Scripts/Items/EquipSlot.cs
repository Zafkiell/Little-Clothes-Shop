using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EquipSlot : MonoBehaviour, IDropHandler
{
    public ItemSO item;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.selectedObject.name);
        item = eventData.selectedObject.GetComponent<Item>().itemSO;
    }
}
