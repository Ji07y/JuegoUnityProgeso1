using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DañoEnemigo : MonoBehaviour


{
    

    public Image vida1;
    public Image vida2;
    public Image vida3;
    public int vidasMaximas = 3;
   public int vidasActual = 3;
    public AudioSource audioSource;



    public TextMeshProUGUI textoVidas;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       if(vidasActual > vidasMaximas)
        {
            vidasActual = vidasMaximas;
        }
       if(vidasActual < 0)
        {
            SceneManager.LoadScene("GameOver");

        }
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            vidasActual = vidasActual - 1;
            ReproducirSonido();
           
            if (vidasActual==2)
            {
                vida3.enabled = false;
            }
            if (vidasActual == 1)
            {
                vida2.enabled = false;
            }
            if (vidasActual == 0)
            {
                vida1.enabled = false;
            }

        }
        if (collision.transform.CompareTag("Vidas"))
        {
            vidasActual = vidasActual + 1;
            
            
            Destroy(collision.gameObject);
            
            if (vidasActual == 2)
            {
                vida2.enabled = true;
            }
            if (vidasActual == 3)
            {
                vida3.enabled = true;
            }
        }
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
