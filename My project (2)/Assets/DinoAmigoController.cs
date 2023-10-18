using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoAmigoController : MonoBehaviour
{
    public float speed = 5.0f; // Velocidad de movimiento del personaje.
    private Rigidbody2D rb;
    private bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundLayer;
    private Animator animator;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Comprobar si el personaje está en el suelo.
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);

        // Establecer el parámetro "IsGrounded" en el Animator.
        animator.SetBool("IsGrounded", isGrounded);

        // Mover al personaje horizontalmente solo de derecha a izquierda.
        float moveDirection = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveDirection * speed, rb.velocity.y);

        // Limitar el cambio de escala (tamaño) del personaje.
        Vector3 newScale = transform.localScale;
        if (moveDirection < 0)
        {
            newScale.x = -1; // Cambia la escala en el eje X para que el personaje mire hacia la izquierda.
        }
        else if (moveDirection > 0)
        {
            newScale.x = 1; // Cambia la escala en el eje X para que el personaje mire hacia la derecha.
        }
        transform.localScale = newScale;

        // No se permite saltar en este ejemplo. Puedes agregarlo si es necesario.
    }
}
