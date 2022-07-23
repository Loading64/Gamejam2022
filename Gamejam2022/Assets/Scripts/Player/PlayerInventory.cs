using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public string Savedweapon = "laser gun";
    public string Savedutility = "empty";
    public GamePlayManager gamePlayManager;
    public void Handcollect(string handtype)
    {
        Debug.Log("HandInventoryGet");
        if (handtype == "laser gun")
        {
            Savedweapon = "laser gun";
            gamePlayManager.weapon = Savedweapon;
            Debug.Log(Savedweapon);
        }
    }

}
