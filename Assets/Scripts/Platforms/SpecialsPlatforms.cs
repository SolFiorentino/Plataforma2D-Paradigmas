using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpecialsPlatforms : MonoBehaviour
{
    protected virtual void Start()
    {
        // Inicio común a todas las plataformas especiales
    }

    protected virtual void Update()
    {
        // Lógica común a todas las plataformas especiales 
    }

    // Método abstracto para manejar la interacción con el jugador
    public abstract void Interact(GameObject player);
}


