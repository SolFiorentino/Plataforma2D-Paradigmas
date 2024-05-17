using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MenuManager : MonoBehaviour
{
    protected bool isMenuActive;

    // M�todo para mostrar el men�
    public abstract void ShowMenu();

    // M�todo para ocultar el men�
    public abstract void HideMenu();

    // M�todo para alternar el estado del men�
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

