using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;

    public void TakenDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            // Game Over Player Dead
        }
    }
}
