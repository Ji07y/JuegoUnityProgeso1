using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraPrimeraPersona : MonoBehaviour
{
    public float sensibilidadRaton = 2.0f;
    public Transform jugador;

    float rotacionVertical = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Captura el movimiento del rat�n
        float rotacionHorizontal = Input.GetAxis("Mouse X") * sensibilidadRaton;
        rotacionVertical -= Input.GetAxis("Mouse Y") * sensibilidadRaton;
        rotacionVertical = Mathf.Clamp(rotacionVertical, -90f, 90f);

        // Aplica la rotaci�n al objeto que lleva la c�mara en los ejes Y y X
        transform.Rotate(Vector3.up * rotacionHorizontal);
        transform.localRotation = Quaternion.Euler(rotacionVertical, 0, 0);

        // Captura el movimiento del teclado para mover al jugador
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcula la direcci�n de movimiento en base a la rotaci�n de la c�mara
        Vector3 direccionMovimiento = (transform.forward * movimientoVertical + transform.right * movimientoHorizontal).normalized;

        // Aplica el movimiento al jugador
        jugador.Translate(direccionMovimiento * Time.deltaTime * 5f);
    }
}

