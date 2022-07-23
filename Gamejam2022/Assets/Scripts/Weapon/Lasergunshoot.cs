using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lasergunshoot : AttackManager
{
    public lasergunbullet projectile;

    public void Fire(string projectile_type)
    {
        if (projectile_type == "lasergun")
        {
            Instantiate(projectile, transform.position, transform.rotation);
            Debug.Log("Shoot!");
        }
    }
}