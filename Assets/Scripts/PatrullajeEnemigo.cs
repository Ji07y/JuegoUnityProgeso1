using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PatrullajeEnemigo : MonoBehaviour
{
   


    public Transform centroDeOrbita;  // Objeto vac�o alrededor del cual se mover� el enemigo.
    public float velocidadRotacion = 2f;  // Velocidad de rotaci�n.
   //ublic float y = 0f;
    private void Update()
    {
        // Aseg�rate de que el centro de orbita est� asignado antes de continuar.
        if (centroDeOrbita == null)
        {
            Debug.LogError("Asigna el centro de orbita en el Inspector.");
            return;
        }

        // Calcula la nueva posici�n en el c�rculo.
        float angulo = Time.time * velocidadRotacion;
        Vector3 posicionNueva = centroDeOrbita.position + new Vector3(Mathf.Cos(angulo), -0.5f, Mathf.Sin(angulo));
        // Mueve el enemigo a la nueva posici�n.
        transform.position = posicionNueva;
    }
}



