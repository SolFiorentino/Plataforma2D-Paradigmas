using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fruits : MonoBehaviour
{
    public int scoreValue = 1; // Puntaje que otorga al recogerlo

    public void Collect()
    {
        // Añadir puntaje al ScoreManager
        Score.Instance.AddScore(scoreValue);
        // Destruir el objeto coleccionable
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Collect();
        }
    }
}



