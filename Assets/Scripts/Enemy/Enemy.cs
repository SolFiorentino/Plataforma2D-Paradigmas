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
        // Comportamiento común de los enemigos 
        Move();
    }

    protected virtual void Move()
    {
        // Método para mover al enemigo
        // Implementación común (no hace nada en este caso)
    }

    public virtual void TakeDamage(int damage)
    {
        // Método para recibir daño
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        // Método para cuando el enemigo muere
        Destroy(gameObject);
    }
}

