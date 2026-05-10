using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.Experimental.Rendering;
using UnityEngine.InputSystem.XR;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class iDIOMA_iNICIO: MonoBehaviour
{
    public TextMeshProUGUI jugarText;
    public TextMeshProUGUI opcionesText;
    public TextMeshProUGUI salirText;




    private int i = 0;
    private string[,] matrizIdiomas = new string[3, 3]
    {
       {"JUGAR","OPCIONES","SALIR" },
       {"PLAY","OPTIONS","GO OUT" },
       {"XOGAR","OPCIONS","SAIR" }
    };

    void Start()
    {
        i = PlayerPrefs.GetInt("Idioma", 0);
        ActualizarTextos();
   
    }



    public void ActualizarTextos()
    {
        jugarText.text = matrizIdiomas[i, 0];
        opcionesText.text = matrizIdiomas[i, 1];
        salirText.text = matrizIdiomas[i, 2];
       
    }
    public void Espanol()

    {
        i = 0;
        ActualizarYGuardar();
    }
    public void Ingles()

    {
        i = 1;
        ActualizarYGuardar();
    }
    public void Galego()

    {
        i = 2;
        ActualizarYGuardar();
    }

    public void ActualizarYGuardar()
    {
        // 1. Guardamos el valor de 'i' en la memoria con la llave "Idioma"
        PlayerPrefs.SetInt("Idioma", i);

        // 2. Forzamos el guardado en el disco
        PlayerPrefs.Save();

        // 3. Actualizamos los textos visuales
        ActualizarTextos();

        Debug.Log("Idioma guardado: " + i);
    }
  

}


