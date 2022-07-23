using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandInteractable : InteractableObject
{
    public GameObject PlayerInventory;
    public PlayerInventory PInv;
    public override void OnPlayerInteracted()
    {
        PInv = PlayerInventory.GetComponent<PlayerInventory>();
        Debug.Log("Hand Get");
        PInv.Handcollect("Ranged");
        GameObject.Destroy(gameObject);
    }
}