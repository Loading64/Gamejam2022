using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerInventory : MonoBehaviour
{
    public string Savedweapon = "empty";
    public string Savedutility = "empty";
    public GamePlayManager gamePlayManager;
    public GameObject pickuptext;
    

    public void Handcollect(string handtype)
    {
        Debug.Log("HandInventoryGet");
        switch (handtype)
        {
            case "lasergun":
                Savedweapon = "lasergun";
                gamePlayManager.weapon = Savedweapon;
                Debug.Log(Savedweapon);

                break;
            case "chargerifle":
                Savedweapon = "chargerifle";
                gamePlayManager.weapon = Savedweapon;
                Debug.Log(Savedweapon);
                break;

            case "thrust":
                Savedutility = "thrust";
                gamePlayManager.utility = Savedutility;
                Debug.Log(Savedutility);
                break;
            default:
                break;
        }
        StartCoroutine(Flashtext());
    }
    IEnumerator Flashtext()
    {
        pickuptext.GetComponent<TMP_Text>().text = Savedweapon;
        yield return new WaitForSeconds(3f);
        pickuptext.GetComponent<TMP_Text>().text = "";

    }




}
