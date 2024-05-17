using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MenuManager
{
    public GameObject startMenuUI;

    private void Start()
    {
        startMenuUI.SetActive(true);
        isMenuActive = true;
    }

    public override void ShowMenu()
    {
        startMenuUI.SetActive(true);
        isMenuActive = true;
    }

    public override void HideMenu()
    {
        startMenuUI.SetActive(false);
        isMenuActive = false;
    }

    // M�todo para iniciar el juego
    public void StartGame()
    {
        HideMenu();
        // L�gica para iniciar el juego (cargar una nueva escena)
        Debug.Log("Game Started");
    }

    // M�todo para salir del juego
    public void QuitGame()
    {
        Debug.Log("Game Quit");
        Application.Quit();
    }
}

