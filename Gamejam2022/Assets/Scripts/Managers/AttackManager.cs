using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{
    public void FireAttack(string weapon)
    {
        switch (weapon)
        {
            case "laser gun":
                //Fire(lasergun);
                Debug.Log("lasergun Attack");
                break;
            case "laser cannon":
                //Fire(lasercannon);
                Debug.Log("lasercannon Attack");
                break;
            case "Charge rifle":
                //Fire(chargerifle)
                Debug.Log("chargerifle Attack");
                break;

            default:
                Debug.Log("Attack Broke");
                Debug.Log(weapon + "attackmanager");
                break;
        }
    }

}
