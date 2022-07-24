using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisiondelete : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        GameObject target = other.gameObject;
        switch(target.tag)
        {
            case "Melee Slime":
                target.GetComponent<MeleeSlime>().damagetaken(1);
                Destroy(gameObject);

                break;
            case "Ranged Slime":
                target.GetComponent<RangedSlime>().damagetaken(1);
                Destroy(gameObject);

                break;
            case "Mother Slime":
                target.GetComponent<MotherSlime>().damagetaken(1);
                Destroy(gameObject);
                break;
        }
    }
}
