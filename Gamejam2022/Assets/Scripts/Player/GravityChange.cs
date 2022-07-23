using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChange : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(SpawnDownThrust());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnDownThrust()
    {
        for (int i = 0; i < 4; i++)
        {
            rb.AddRelativeForce(Vector3.down * thrust);
            yield return new WaitForSeconds(0.1f);
        }
    }

}
