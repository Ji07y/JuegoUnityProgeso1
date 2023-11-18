using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ControladorAudio : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Obt�n el componente AudioSource adjunto al GameObject.
        audioSource = GetComponent<AudioSource>();
    }

    // M�todo para cambiar el estado del audio (habilitar o deshabilitar).
    public void CambiarEstadoAudio()
    {
        if (audioSource != null)
        {
            // Invierte el estado actual del audio.
            audioSource.enabled = !audioSource.enabled;
        }
    }
}
