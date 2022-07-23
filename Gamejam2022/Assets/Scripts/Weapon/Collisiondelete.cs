using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisiondelete : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision");
        GameObject target = other.gameObject;
        if (target.tag == "Slime")
        {
            Destroy(target);
        }
    }
}

