using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour
{
    // M�todo abstracto para activar el PowerUp
    public abstract void Activate(GameObject player);

    // M�todo para destruir el PowerUp despu�s de recogerlo
    protected void DestroyPowerUp()
    {
        Destroy(gameObject);
    }
}

