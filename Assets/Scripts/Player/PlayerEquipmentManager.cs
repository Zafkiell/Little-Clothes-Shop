using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquipmentManager : MonoBehaviour
{
    public GameObject playerHeadPiece;
    public GameObject playerClothesPiece;

    public ItemSO headPiece;
    public ItemSO clothesPiece;
    // Start is called before the first frame update
    void Start()
    {
        if(headPiece.itemAnimController != null)
            playerHeadPiece.GetComponent<Animator>().runtimeAnimatorController = headPiece.itemAnimController;

        if(clothesPiece.itemAnimController != null)
            playerClothesPiece.GetComponent<Animator>().runtimeAnimatorController = clothesPiece.itemAnimController;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
