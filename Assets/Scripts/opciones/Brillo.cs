
using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Brillo : MonoBehaviour
{
    public Image Panel_Brillo;
    public Slider Slider_Brillo;
    public GameObject Text_Imagen;
    public GameObject Text_Volumen;
    public GameObject Text_Jugabilidad;
    public GameObject Text_Idiomas;

    public GameObject[] todosLosPaneles;
    public Toggle toggle;


    [HeaderAttribute("Cambio de resolución")]
    public TMP_Dropdown resolucionesDropDown;
  

    public void Pantalla_BrilloEntra(GameObject panelAActivar)
    {
        Text_Imagen.SetActive(false);

        Text_Volumen.SetActive(true);
        Text_Jugabilidad.SetActive(true);
        Text_Idiomas.SetActive(true);
    }
    public void AbrirPanelEspecifico(int indice)
    {
        for (int i = 0; i < todosLosPaneles.Length; i++)
        {

            todosLosPaneles[i].SetActive(i == indice);
        }
    }
    private int[][] resoluciones = new int[][]
    {
        new int[]{1280,720},
        new int[]{1920,1080},
        new int[]{2560,1440},
        new int[]{3840,2160}

    };
    void Start()




    {
        float brilloGuardado = PlayerPrefs.GetFloat("Brillo", 100f);
        Slider_Brillo.value = brilloGuardado;

        CambiarBrillo(brilloGuardado);

        Slider_Brillo.onValueChanged.AddListener(CambiarBrillo);

    if (Screen.fullScreen)
        {
            toggle.isOn = true; 
        }
        else
        {
            toggle.isOn = false;
        }

        RevisarResolucion();
    }

    void Upgrade()
    { }
    public void ActivePantallaCompleta(bool pantallaCompleta) 
    {
        Screen.fullScreen = pantallaCompleta; 
    }

    public void RevisarResolucion()
   
    {
        resolucionesDropDown.ClearOptions();
        var opciones = new System.Collections.Generic.List<string>();
        foreach (var r in resoluciones)
        {
            opciones.Add(r[0] + " " + r[1]);
        }
        resolucionesDropDown.AddOptions(opciones);
        resolucionesDropDown.value = 0;
        resolucionesDropDown.RefreshShownValue();
    }
    public void CambiarResolucion(int indiceResolucion)
    {
        int ancho = resoluciones[indiceResolucion][0];
        int alto = resoluciones[indiceResolucion][1];

        FullScreenMode modoActual = Screen.fullScreenMode;

        Screen.SetResolution(ancho, alto, modoActual);
    }

    public void CambiarBrillo(float valor)

    {
        Color c = Panel_Brillo.color;
        c.a = 1f - valor / 10;
        Panel_Brillo.color = c;
        PlayerPrefs.SetFloat("Brillo", valor);
        PlayerPrefs.Save();

    }


    

    






}
   


