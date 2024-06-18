using UnityEngine;
using UnityEngine.UI;

public class DefeatScreen : MonoBehaviour
{
    public GameObject defeatScreen;

    private void Start()
    {
        defeatScreen.SetActive(false); 
        Life.Instance.onPlayerDeath.AddListener(ShowDefeatScreen); // Suscribirse al evento de muerte del jugador
    }

    private void ShowDefeatScreen()
    {
        defeatScreen.SetActive(true); 
    }
}
