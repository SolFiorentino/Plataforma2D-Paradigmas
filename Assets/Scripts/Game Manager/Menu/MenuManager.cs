using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MenuManager : MonoBehaviour
{
    protected bool isMenuActive;

    // Método para mostrar el menú
    public abstract void ShowMenu();

    // Método para ocultar el menú
    public abstract void HideMenu();

    // Método para alternar el estado del menú
    public void ToggleMenu()
    {
        if (isMenuActive)
        {
            HideMenu();
        }
        else
        {
            ShowMenu();
        }
    }
}

