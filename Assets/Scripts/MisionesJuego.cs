using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MisionesJuego : MonoBehaviour
{
    public GameObject jugador; // Asigna el GameObject del jugador desde el editor.
    public GameObject imagenActivar; // Asigna la imagen que quieres activar desde el editor.
    public TextMeshProUGUI textoMostrarMision; // Asigna el objeto de texto que quieres mostrar desde el editor.

    
    // Start is called before the first frame update
    void Start()
    {
        imagenActivar.SetActive(false);
    }




    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto que entró en el trigger es el jugador.
        if (other.gameObject == jugador)
        {
            // Activa la imagen y establece el texto.
            imagenActivar.SetActive(true);
            textoMostrarMision.enabled = true;
            textoMostrarMision.text = " Explora nuestro entorno urbano y recolecta la valiosa basura reciclable" +
                " dispersa por la ciudad. Equipado/a con tu recolector de residuos," +
                " enfréntate a las calles y parques para limpiar nuestro hogar.";
        }
       
    }
    private void OnTriggerExit(Collider other)
    {
        // Verifica si el objeto que salió del trigger es el jugador.
        if (other.gameObject == jugador)
        {
            // Desactiva la imagen y limpia el texto.
            imagenActivar.SetActive(false);
            textoMostrarMision.enabled = false;
        }
    }
}