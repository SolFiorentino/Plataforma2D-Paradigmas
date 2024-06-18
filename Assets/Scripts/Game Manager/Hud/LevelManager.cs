using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : GameManager
{
    public string Level1; 
    private int totalFruits;
    private int collectedFruits;

    protected override void Awake()
    {
        base.Awake();
        if (instance == this) 
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        InitializeFruits();
    }

    private void InitializeFruits()
    {
        // Encontrar todas las frutas en la escena
        Fruits[] fruits = FindObjectsOfType<Fruits>();
        totalFruits = fruits.Length;
        collectedFruits = 0;

        // Suscribirse al evento de recolección de cada fruta
        foreach (Fruits fruit in fruits)
        {
            fruit.onCollected.AddListener(OnFruitCollected);
        }
    }

    private void OnFruitCollected()
    {
        collectedFruits++;
        Debug.Log("Fruits Collected: " + collectedFruits + "/" + totalFruits);
        if (collectedFruits >= totalFruits)
        {
            Debug.Log("All Fruits Collected");
            // Lógica para pasar al siguiente nivel
            LoadNextLevel();
        }
    }

    private void LoadNextLevel()
    {
        SceneManager.LoadScene(Level1);
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        InitializeFruits();
    }
}

