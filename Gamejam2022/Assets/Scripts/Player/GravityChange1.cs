using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChange1 : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void thrustutility()
    {
        StartCoroutine(SpawnforwardThrust());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnforwardThrust()
    {
        for (int i = 0; i < 1; i++)
        {
            rb.AddRelativeForce(Vector3.forward * thrust);
            yield return new WaitForSeconds(3f);
        }
    }


}
