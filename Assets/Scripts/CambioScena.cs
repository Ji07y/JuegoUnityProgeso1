using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugar : MonoBehaviour
{
  
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            CambiarAJuego();
        }
        if (Input.GetKeyUp(KeyCode.M))
        {
            CambiarMenu();
        }
        if (Input.GetKeyUp(KeyCode.Return))
        {
            CambiarAJuego();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            SalirJuego();
        }
    }
    public void CambiarAJuego()
    {
        SceneManager.LoadScene(1);
    }
    public void CambiarMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void SalirJuego()
    {
        Application.Quit();
    }

}
