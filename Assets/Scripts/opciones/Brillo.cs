
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
    public TMP_Dropdown resolucionesDropDown;
    Resolution[] resoluciones;

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
        resoluciones = Screen.resolutions;
        resolucionesDropDown.ClearOptions();
        List<string> opciones = new List<string>();
        int resolucionActual = 0;

        for (int i= 0; i < resoluciones.Length; i++)
        {
            string opcion = resoluciones[i].width + " x " + resoluciones[i].height;
            opciones.Add(opcion);


            if (Screen.fullScreen && resoluciones[i].width == Screen.currentResolution.width &&
                resoluciones[i].height == Screen.currentResolution.height)
            { 
                resolucionActual = i; 
            }
        }
        resolucionesDropDown.AddOptions(opciones);
        resolucionesDropDown.value = resolucionActual;
        resolucionesDropDown.RefreshShownValue();

    }
    public void CambiarResolucion(int indiceResolucion) 
    {
        Resolution resolucion = resoluciones[indiceResolucion];
        Screen.SetResolution(resolucion.width, resolucion.height, Screen.fullScreen);
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
   


