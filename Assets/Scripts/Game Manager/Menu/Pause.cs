using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MenuManager
{
    public GameObject pauseMenuUI;

    private void Start()
    {
        pauseMenuUI.SetActive(false);
        isMenuActive = false;
    }

    public override void ShowMenu()
    {
        // Lógica para pausar el juego

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;          
        isMenuActive = true;
    }


    // Lógica para reanudar el juego
    public override void HideMenu()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;            
        isMenuActive = false;
    }
}

