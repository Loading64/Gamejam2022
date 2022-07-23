using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lasergunshoot : MonoBehaviour
{
    public lasergunbullet projectile;

    public void Fire(string projectile_type)
    {
        switch (projectile_type)
        {
            case "lasergun":
                Instantiate(projectile, transform.position, transform.rotation);
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
                Debug.Log(projectile_type + "projectile_type");
                break;
        }

    }
}