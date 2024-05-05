using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class Slot : MonoBehaviour, IDropHandler
{
    public Image slotImage;
    public ItemSO slotItemSo;

    public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.transform.parent = transform.parent;

            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition =
                GetComponent<RectTransform>().anchoredPosition;

        }
    }

    private void Start()
    {
        slotImage = GetComponent<Image>();
    }
}
