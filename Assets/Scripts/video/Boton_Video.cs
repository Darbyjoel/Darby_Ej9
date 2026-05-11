using UnityEngine;
using UnityEngine.SceneManagement;

public class Boton_Video : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void CambiodeEscena()
    {
        SceneManager.LoadScene("MenuJuego");

    }
}

