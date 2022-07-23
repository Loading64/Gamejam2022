using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    string CurrentLeft = "empty";
    string CurrentRight = "empty";
    public void Handcollect(string handtype)
    {
        Debug.Log("HandInventoryGet");
        if (handtype == "Ranged")
        {
            CurrentRight = "ranged";
        }
    }

}
