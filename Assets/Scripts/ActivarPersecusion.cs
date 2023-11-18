using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarPersecusion : MonoBehaviour
{
    public GameObject objetoConScript;  // Asigna el GameObject que tiene el script desde el editor.

    public GameObject jugador;



    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que entró en el trigger es el jugador.
        if (other.gameObject == jugador)
        {
            // Activa la imagen y establece el texto.
            EnemyFollow miScript = objetoConScript.GetComponent<EnemyFollow>();
            PatrullajeEnemigo patrullaje = objetoConScript.GetComponent<PatrullajeEnemigo>();
            miScript.enabled = true;
            patrullaje.enabled = false;

        }
    }

    
}
