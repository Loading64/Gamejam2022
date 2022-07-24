using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisiondelete : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        GameObject target = other.gameObject;
        if (target.tag == "slime")
        {
            target.GetComponent<MeleeSlime>().damagetaken(1);
            Debug.Log("hitslime");
            Destroy(gameObject);
        }
    }
}
