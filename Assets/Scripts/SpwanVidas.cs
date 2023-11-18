using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpwanVidas : MonoBehaviour
{
    public GameObject prefabVidas;
    // Start is called beore the first frame update
    void Start()
    {
        InvokeRepeating("GenerarVidas", 2f, 60f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void GenerarVidas()
    {
        float posX = Random.Range(-31.6f, 35.6f);
        float posZ = Random.Range(-24, 78.3f);

        Vector3 posicionAleatoria = new Vector3(posX, 0.37f, posZ);

        // Crea el objeto "basura" en la posición aleatoria
        GameObject nuevoVida = Instantiate(prefabVidas, posicionAleatoria, Quaternion.identity);
    }

}
