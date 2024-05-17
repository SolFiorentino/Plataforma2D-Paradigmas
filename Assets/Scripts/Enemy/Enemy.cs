using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    // Propiedades comunes de los enemigos
    public int health = 100;
    public float speed = 3f;

    protected Rigidbody2D rb;

    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    protected virtual void Update()
    {
        // Comportamiento com�n de los enemigos 
        Move();
    }

    protected virtual void Move()
    {
        // M�todo para mover al enemigo
        // Implementaci�n com�n (no hace nada en este caso)
    }

    public virtual void TakeDamage(int damage)
    {
        // M�todo para recibir da�o
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        // M�todo para cuando el enemigo muere
        Destroy(gameObject);
    }
}

