using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemigoBuscaJugador : MonoBehaviour
{
    public Transform posicionInicial; // Asigna la posici�n inicial del enemigo desde el editor.
    public float radioDeteccion = 5f; // Asigna el radio de detecci�n desde el editor.
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
            // El jugador est� dentro del radio de detecci�n.
            jugadorDetectado = true;
            ActivarNavMeshAgent();

        }
        else if (jugadorDetectado)
        {
            // El jugador sali� del radio de detecci�n, vuelve a la posici�n inicial.
            VolverAPosicionInicial();
            jugadorDetectado = false;
            DesactivarNavMeshAgent();
        }
    }

    void VolverAPosicionInicial()
    {
        // Mueve al enemigo de nuevo a su posici�n inicial.
        transform.position = posicionInicial.position;
    }
    public void ActivarNavMeshAgent()
    {
        if (navMeshAgent != null)
        {
            navMeshAgent.enabled = true;
        }
    }

    // M�todo para desactivar el NavMeshAgent.
    public void DesactivarNavMeshAgent()
    {
        if (navMeshAgent != null)
        {
            navMeshAgent.enabled = false;
        }
    }
}
