using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Fly : Enemy
{
    public float FlightHeight = 3f; // Altura a la que planea el enemigo

    protected override void Start()
    {
        base.Start();
        //  Velocidad enemigo volador
        speed = 6f;
    }

    protected override void Update()
    {
        base.Update();
        // Implementar el comportamiento de vuelo del enemigo volador
        Flying();
    }

    protected override void Move()
    {
        // Sobrescribe el método Move para el enemigo volador
        
    }

    private void Flying ()
    {
        // Método específico para el vuelo 
        // Mueve al enemigo hacia arriba y abajo para simular un vuelo
       
    }
}

