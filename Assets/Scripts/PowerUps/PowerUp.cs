using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour
{
    // Método abstracto para activar el PowerUp
    public abstract void Activate(GameObject player);

    // Método para destruir el PowerUp después de recogerlo
    protected void DestroyPowerUp()
    {
        Destroy(gameObject);
    }
}

