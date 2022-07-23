using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lasergunshoot : MonoBehaviour
{
    public lasergunbullet projectile;

    public void Fire(string projectile_type)
    {
        IEnumerator chargeriflefire()
        {
            Instantiate(projectile, transform.position, transform.rotation);
            yield return new WaitForSeconds(0.12f);
            Instantiate(projectile, transform.position, transform.rotation);
            yield return new WaitForSeconds(0.11f);
            Instantiate(projectile, transform.position, transform.rotation);
            yield return new WaitForSeconds(0.15f);
        }

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
        if (projectile_type == "chargerifle")
        {
            StartCoroutine(chargeriflefire());

        }

    }
}