using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisiondelete : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        GameObject target = other.gameObject;
        if (target.tag == "Slime")
        {
            Destroy(target);
            target.GetComponent<MeleeSlime>().damagetaken(1);
        }
    }
}
