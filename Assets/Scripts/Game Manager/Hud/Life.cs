using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : GameManager
{
    public int maxHealth = 100;
    private int currentHealth; 

    protected override void Awake()
    {
        base.Awake();
        currentHealth = maxHealth; // Cuando inicia el juego la vida esta al máximo
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("Player Died");
            // Lógica adicional para cuando el jugador muera
        }
        Debug.Log("Current Health: " + currentHealth);
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        Debug.Log("Current Health: " + currentHealth);
    }

    public static Life Instance
    {
        get { return GetInstance<Life>(); }
    }
}

