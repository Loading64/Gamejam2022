using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{   
    public GameObject originpoint;
    public GameObject firstpersoncontroller;
    private Lasergunshoot lasergunscript;
    private GravityChange1 thrustscript;
    private void Start()
    {
        lasergunscript = originpoint.GetComponent<Lasergunshoot>();
        thrustscript = firstpersoncontroller.GetComponent<GravityChange1>();
    }
    public void FireAttack(string weapon)
    {
        switch (weapon)
        {
            case "lasergun":
                lasergunscript.Fire("lasergun");
                Debug.Log("lasergun Attack");
                break;
            case "lasercannon":
                //Fire(lasercannon);
                Debug.Log("lasercannon Attack");
                break;
            case "chargerifle":
                lasergunscript.Fire("chargerifle");
                Debug.Log("chargerifle Attack");
                break;

            default:
                Debug.Log("Attack Broke");
                Debug.Log(weapon + "attackmanager");
                break;
        }
    }
    public void FireUtility(string utility)
    {
        switch (utility)
        {
            case "thrust":
                thrustscript.thrustutility();
                Debug.Log("thrust");
                break;
            default:
                Debug.Log("utility Broke");
                Debug.Log(utility + "UtilityManager");
                break;

        }

    }


}
