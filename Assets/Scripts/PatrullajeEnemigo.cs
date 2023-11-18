using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PatrullajeEnemigo : MonoBehaviour
{
   


    public Transform centroDeOrbita;  // Objeto vacío alrededor del cual se moverá el enemigo.
    public float velocidadRotacion = 2f;  // Velocidad de rotación.
   //ublic float y = 0f;
    private void Update()
    {
        // Asegúrate de que el centro de orbita esté asignado antes de continuar.
        if (centroDeOrbita == null)
        {
            Debug.LogError("Asigna el centro de orbita en el Inspector.");
            return;
        }

        // Calcula la nueva posición en el círculo.
        float angulo = Time.time * velocidadRotacion;
        Vector3 posicionNueva = centroDeOrbita.position + new Vector3(Mathf.Cos(angulo), -0.5f, Mathf.Sin(angulo));
        // Mueve el enemigo a la nueva posición.
        transform.position = posicionNueva;
    }
}



