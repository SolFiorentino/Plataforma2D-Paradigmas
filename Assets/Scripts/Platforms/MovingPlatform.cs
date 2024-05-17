using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class MovingPlatform : SpecialsPlatforms
{
    public Vector3 pointA;
    public Vector3 pointB;
    public float speed = 1f;
    private bool movingToB = true;

    protected override void Start()
    {
        base.Start();
        transform.position = pointA;
    }

    protected override void Update()
    {
        base.Update();
        MovePlatform();
    }

    private void MovePlatform()
    {
        if (movingToB)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointB, speed * Time.deltaTime);
            if (transform.position == pointB)
            {
                movingToB = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, pointA, speed * Time.deltaTime);
            if (transform.position == pointA)
            {
                movingToB = true;
            }
        }
    }

    public override void Interact(GameObject player)
    {
        // No hay interacción especial en la plataforma en movimiento, pero se podría agregar si es necesario
    }
}
