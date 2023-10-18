using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("dinovercionreinicio"); // Reemplaza "NombreDeTuEscenaDelJuego" por el nombre de la escena de tu juego.
    }
}
