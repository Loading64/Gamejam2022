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

        if (projectile_type == "lasergun")
        {
            Instantiate(projectile, transform.position, transform.rotation);
            Debug.Log("Shoot!");
        }
        if (projectile_type == "chargerifle")
        {
            StartCoroutine(chargeriflefire());

        }

    }
}