using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Player
{
    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        Move(moveInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
}
