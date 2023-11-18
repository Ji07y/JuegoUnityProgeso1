using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemigoBuscaJugador : MonoBehaviour
{
    public Transform posicionInicial; // Asigna la posición inicial del enemigo desde el editor.
    public float radioDeteccion = 5f; // Asigna el radio de detección desde el editor.
    private Transform jugador; // Referencia al jugador.
    private bool jugadorDetectado = false;
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player").transform; // Asume que el jugador tiene la etiqueta "Player".
    }

    void Update()
    {
        float distanciaAlJugador = Vector3.Distance(transform.position, jugador.position);

        if (distanciaAlJugador <= radioDeteccion)
        {
            // El jugador está dentro del radio de detección.
            jugadorDetectado = true;
            ActivarNavMeshAgent();

        }
        else if (jugadorDetectado)
        {
            // El jugador salió del radio de detección, vuelve a la posición inicial.
            VolverAPosicionInicial();
            jugadorDetectado = false;
            DesactivarNavMeshAgent();
        }
    }

    void VolverAPosicionInicial()
    {
        // Mueve al enemigo de nuevo a su posición inicial.
        transform.position = posicionInicial.position;
    }
    public void ActivarNavMeshAgent()
    {
        if (navMeshAgent != null)
        {
            navMeshAgent.enabled = true;
        }
    }

    // Método para desactivar el NavMeshAgent.
    public void DesactivarNavMeshAgent()
    {
        if (navMeshAgent != null)
        {
            navMeshAgent.enabled = false;
        }
    }
}
