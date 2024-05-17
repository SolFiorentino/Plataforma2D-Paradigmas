using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolinePlatform : SpecialsPlatforms
{
    public float jumpforce = 10f;

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Interact(collision.gameObject);
        }
    }

    public override void Interact(GameObject player)
    {
        Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
        }
    }
}
