using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoritoController : MonoBehaviour
{
    public float velocidadCaida = 0.5f; // Velocidad de caída de los meteoritos.
    public Vector2 spawnPosicionXRange; // Rango de posición X para la aparición de meteoritos.

    private bool haCaido = false; // Variable para rastrear si el meteorito ya ha caído.

    private void Update()
    {
        // Si el meteorito ya ha caído, no hacemos nada.
        if (haCaido)
        {
            return;
        }

        // Mueve el meteorito hacia abajo.
        transform.Translate(Vector3.down * velocidadCaida * Time.deltaTime);

        // Si el meteorito está fuera de la pantalla, destrúyelo y marca que ha caído.
        if (transform.position.y < -10f)
        {
            Destroy(gameObject);
            haCaido = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Detecta colisión con el suelo.
        if (other.CompareTag("Suelo"))
        {
            Destroy(gameObject); // Destruye el meteorito.
        }
        // Detecta colisión con DinoAmigo.
        else if (other.CompareTag("Player"))
        {
            Time.timeScale = 1f; // Pausa el juego.
            // Aquí puedes mostrar un mensaje de Game Over o realizar otras acciones.
        }
    }
}
