using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public Image healthBar;

    public void TakenDamage(int damage)
    {
        health -= damage;
        healthBar.fillAmount = health / 10;
        if(health <= 0)
        {
            // Game Over Player Dead
            Application.Quit();
        }
    }
}
