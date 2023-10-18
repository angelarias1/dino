using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temporizador : MonoBehaviour
{
    public float tiempoLimite = 30f; // Tiempo en segundos antes de mostrar la imagen.
    public Image imagenMostrar; // Referencia a la imagen que se mostrará.

    private float tiempoTranscurrido = 0f;
    private bool mostrarImagen = false;

    private void Update()
    {
        if (!mostrarImagen)
        {
            tiempoTranscurrido += Time.deltaTime;

            // Verifica si ha transcurrido el tiempo límite.
            if (tiempoTranscurrido >= tiempoLimite)
            {
                // Activa la imagen para mostrarla.
                if (imagenMostrar != null)
                {
                    imagenMostrar.gameObject.SetActive(true);
                    mostrarImagen = true;
                }
            }
        }
    }
}
