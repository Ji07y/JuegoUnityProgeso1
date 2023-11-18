using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEditor.Build.Content;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;



public class LimpiadorBasura : MonoBehaviour
{
    [System.Serializable]
    public class DatosJuego
    {
        public int numeroObjetosReciclados = 0;  // Cambiado a público para que sea accesible desde fuera.
    }

    public Image basura;
    private float distanciaRecogida = 20f;
    public TextMeshProUGUI textoBasura;
    public TextMeshProUGUI textoGuiaReciclaje;
    public AudioSource audioSource;

    private DatosJuego datos;  // Se movió aquí para que no se reinicie cada vez que se llama GuardarDatos.

    private string guiaObjReciclable = "RECUERDA: Botellas de plástico, latas de aluminio, envases de cartón, vidrio," +
        " papel, botellas de vidrio, latas de acero, cajas de cartón." +
        " ¡Recicla y contribuye a un mundo más sostenible!";

    private void Start()
    {
        datos = new DatosJuego();  // Inicializado una vez al inicio.
        ActualizarTextoBasura();
        textoGuiaReciclaje.gameObject.SetActive(false);
    }

    void Update()
    {
        VisualizarRaycast();

        if (Input.GetButtonDown("Fire1"))  // Personaliza según tu configuración de entrada
        {
            RecogerBasura();
            ReproducirSonido();
        }
    }

    void VisualizarRaycast()
    {
        Debug.DrawRay(transform.position, transform.forward * distanciaRecogida, Color.red);
    }

    private void RecogerBasura()
    {
        RaycastHit hit;
        Ray myRay = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(myRay, out hit))
        {
            if (hit.transform.CompareTag("Reciclable"))
            {
                Destroy(hit.collider.gameObject);
                datos.numeroObjetosReciclados++;
                ActualizarTextoBasura();
                GuardarDatos();
            }
            if (hit.transform.CompareTag("NoReciclable"))
            {
                ActivarTextoPorTiempoLimitado();
            }
            
        }
    }

    void ActualizarTextoBasura()
    {
        textoBasura.text = "Objetos Reciclables: " + datos.numeroObjetosReciclados;
    }

    public void GuardarDatos()
    {
        string jsonString = JsonUtility.ToJson(datos);

        // Guarda el archivo JSON en la carpeta persistente de datos de Unity.
        string filePath = Path.Combine(Application.persistentDataPath, "datosJuego.json");
        File.WriteAllText(filePath, jsonString);
    }

    void ActivarTextoPorTiempoLimitado()
    {
        // Activa el texto.
        textoGuiaReciclaje.text = guiaObjReciclable;
        textoGuiaReciclaje.gameObject.SetActive(true);


        // Inicia la corutina para desactivar el texto después de un tiempo.
        StartCoroutine(DesactivarTextoDespuesDeTiempo());
    }

    IEnumerator DesactivarTextoDespuesDeTiempo()
    {
        // Espera durante el tiempo especificado.
        yield return new WaitForSeconds(5f);

        // Desactiva el texto después del tiempo especificado.
        textoGuiaReciclaje.gameObject.SetActive(false);
    }

    void ReproducirSonido()
    {
        // Asegúrate de tener un AudioSource asignado en el Inspector.
        if (audioSource != null)
        {
            // Reproduce el sonido.
            audioSource.Play();
        }
    }





}


