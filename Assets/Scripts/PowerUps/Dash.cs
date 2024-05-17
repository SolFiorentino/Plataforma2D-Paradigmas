using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : PowerUp
{
    public float dashDistance = 5f;
    public float dashCooldown = 2f;

    private bool canDash = true;

    public override void Activate(GameObject player)
    {
        Dash playerDash = player.GetComponent<Dash>();
        if (playerDash != null && canDash)
        {
          //  playerDash.Dash(dashDistance);
            canDash = false;
            StartCoroutine(ResetDashCooldown());
        }
        DestroyPowerUp();
    }

    private IEnumerator ResetDashCooldown()
    {
        yield return new WaitForSeconds(dashCooldown);
        canDash = true;
    }
}

