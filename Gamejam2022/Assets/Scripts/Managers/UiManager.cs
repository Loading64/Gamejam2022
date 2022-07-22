using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int health;

    void Start()
    {
        
    }

    public void takendamage(int damage)
    {
        health -= damage;

    }

}
