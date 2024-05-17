using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Plant : Enemy
{
    public GameObject projectilePrefab; // Prefab del proyectil
    public Transform shootPoint;       // Punto desde donde se disparan los proyectiles
    public float shootInterval = 2f;  // Intervalo entre disparos en segundos

    private float shootTimer = 0f;

    protected override void Update()
    {
        base.Update();
        
        // Dispara proyectiles a intervalos regulares
       
        Shoot();
    }

    private void Shoot()
    {
        // Actualiza el temporizador
        shootTimer += Time.deltaTime;

        // Si ha pasado el intervalo de disparo, dispara un proyectil
        if (shootTimer >= shootInterval)
        {
            Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
           
            
            shootTimer = 0f; // Reinicia el temporizador
        }
    }
}
