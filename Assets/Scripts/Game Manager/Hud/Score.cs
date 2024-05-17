using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : GameManager
{
    private int score;

    protected override void Awake()
    {
        base.Awake();
        score = 0; // Puntaje a 0 al iniciar el juego
    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Current Score: " + score);
       
        // Actualizar la UI del juego para mostrar el puntaje actual
    }

    public static Score Instance
    {
        get { return GetInstance<Score>(); }
    }
}
