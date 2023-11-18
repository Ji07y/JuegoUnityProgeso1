using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LeerJson : MonoBehaviour
{
    [System.Serializable]
    public class DatosJuego
    {
        public int numeroObjetosReciclados;
        
    }

   
    public TextMeshProUGUI textoNumeroObjetos;


    // Método para leer y mostrar datos desde el archivo JSON.
    void Start()
    {
        // Cargar el archivo JSON desde la carpeta persistente de datos de Unity.
        string filePath = Path.Combine(Application.persistentDataPath, "datosJuego.json");

        if (File.Exists(filePath))
        {
            string jsonString = File.ReadAllText(filePath);
            DatosJuego datos = JsonUtility.FromJson<DatosJuego>(jsonString);

            // Mostrar la información en la interfaz de usuario.
            textoNumeroObjetos.text = "OBJETOS RECICLADOS: " + datos.numeroObjetosReciclados.ToString();
            
        }
        else
        {
            Debug.Log("No se encontró el archivo JSON.");
        }
    }
}



