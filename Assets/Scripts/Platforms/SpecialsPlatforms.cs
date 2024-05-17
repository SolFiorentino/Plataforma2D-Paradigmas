using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpecialsPlatforms : MonoBehaviour
{
    protected virtual void Start()
    {
        // Inicio com�n a todas las plataformas especiales
    }

    protected virtual void Update()
    {
        // L�gica com�n a todas las plataformas especiales 
    }

    // M�todo abstracto para manejar la interacci�n con el jugador
    public abstract void Interact(GameObject player);
}


