using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColocadorBasura : MonoBehaviour
{
    public GameObject basuraRPrefab;
    public GameObject basuraNRPrefab;
    public int cantidadDeBasura = 20;
    public float rangoX = 50f;
    public float rangoZ = 50f;

    void Start()
    {
        ColocarBasuraAleatoriamente();
    }

    void ColocarBasuraAleatoriamente()
    {
        for (int i = 0; i < cantidadDeBasura; i++)
        {
            float posX = Random.Range(-31.6f, 35.6f);
            float posZ = Random.Range(-24,78.3f);

            Vector3 posicionAleatoria = new Vector3(posX, 0.5f, posZ);

            // Crea el objeto "basura" en la posición aleatoria
            GameObject nuevoObjetoBasura = Instantiate(basuraRPrefab, posicionAleatoria, Quaternion.identity);
            GameObject nuevoObjetoBasuraR = Instantiate(basuraNRPrefab, posicionAleatoria, Quaternion.identity);
            // Si "basura" tiene hijos, ajusta sus posiciones locales
            if (basuraNRPrefab.transform.childCount > 0)
            {
                foreach (Transform hijo in basuraNRPrefab.transform)
                {
                    // Calcula la posición relativa del hijo y asigna la posición al nuevo objeto instanciado
                    Vector3 posicionRelativaHijo = hijo.localPosition;
                    hijo.localPosition = posicionRelativaHijo;
                }
            }
            if (basuraRPrefab.transform.childCount > 0)
            {
                foreach (Transform hijo in basuraRPrefab.transform)
                {
                    // Calcula la posición relativa del hijo y asigna la posición al nuevo objeto instanciado
                    Vector3 posicionRelativaHijo = hijo.localPosition;
                    hijo.localPosition = posicionRelativaHijo;
                }
            }
        }
    }
}

