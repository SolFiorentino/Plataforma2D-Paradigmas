using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
    // Movimiento del jugador
    public float Speed { get; protected set; }
    public float JumpForce { get; protected set; }

    protected Rigidbody2D rb;

    protected virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Componente Rigidbody2D del jugador
        Speed = 3f;
        JumpForce = 4f;
    }

    protected virtual void Move(float moveInput)
    {
        // Mover el jugador horizontalmente
        Vector2 movement = new Vector2(moveInput * Speed, rb.velocity.y);
        rb.velocity = movement;

        // Girar al jugador según la dirección del movimiento
        if (moveInput < 0)
            transform.localScale = new Vector3(-1, 1, 1);
        else if (moveInput > 0)
            transform.localScale = new Vector3(1, 1, 1);
    }

    protected virtual void Jump()
    {
        // Salto del jugador
        if (IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpForce);
        }
    }

    protected virtual bool IsGrounded()
    {
        // Verificar si el jugador está en el suelo
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);
        return hit.collider != null;
    }

    protected virtual void Update()
    {
        // Este método será sobreescrito por las clases derivadas según sea necesario
    }

    // Lógica para recolectar las frutas
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruits"))
        {
            Fruits fruit = collision.gameObject.GetComponent<Fruits>();
            if (fruit != null)
            {
                fruit.Collect();
            }
        }

        // Lógica para recolctar el power up

        if (collision.CompareTag("PowerUp"))
        {
            PowerUp powerUp = collision.gameObject.GetComponent<PowerUp>();
            if (powerUp != null)
            {
                powerUp.Activate(gameObject);
            }
        }


    }


}











