using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandInteractable : InteractableObject
{
    public GameObject PlayerInventory;
    public PlayerInventory PInv;
    public void OnPlayerInteracted1()
    {
        PInv = PlayerInventory.GetComponent<PlayerInventory>();
        Debug.Log("Hand Get");
        PInv.Handcollect("laser gun");
        GameObject.Destroy(gameObject);
    }
}
