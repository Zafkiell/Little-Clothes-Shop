using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

[CreateAssetMenu(fileName = "Item SO", menuName = "Scriptable Objetcs/Items")]
public class ItemSO : ScriptableObject
{
    public Sprite itemSprite;
    public AnimatorController itemAnimController;
    public string itemType;
}
