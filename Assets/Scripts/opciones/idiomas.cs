using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.Experimental.Rendering;
using UnityEngine.InputSystem.XR;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class idiomas : MonoBehaviour
{
    public TextMeshProUGUI botonEspañolText;
    public TextMeshProUGUI botonInglesText;
    public TextMeshProUGUI botonGallegoText;
    public TextMeshProUGUI botonIDIOMAText;
    public TextMeshProUGUI IdiomaSistemaText;
    public TextMeshProUGUI JugabilidadText;
    public TextMeshProUGUI ImagenText;
    public TextMeshProUGUI VolumenText;
    public TextMeshProUGUI MandoText;
    public TextMeshProUGUI BrilloText;
    public TextMeshProUGUI ResolucionText;
    public TextMeshProUGUI PredeterminadoText;
    public TextMeshProUGUI SonidoText;
    public TextMeshProUGUI MusicaText;
    public TextMeshProUGUI DialogosText;
    public TextMeshProUGUI FxText;
    public TextMeshProUGUI DificultadText;



    private int i = 0;
    private string[,] matrizIdiomas = new string[3, 17]
    {
       {"CASTELLANO","ÍNGLES","GALLEGO", "IDIOMA","IDIOMAS DEL SISTEMA","JUGABILIDAD","IMAGEN","VOLUMEN","MANDO","BRILLO","RESOLUCIÓN Y TAMAÑO","PREDETERMINADO","SONIDO","MÚSICA","DÍALOGO","FX","DIFICILTAD"},
       {"SPANISH","ENGLISH","GALICIAN", "LANGUAGE","SYSTEM LANGUAGES","GAMEPLAY","IMAGE","VOLUME","CONTROLLER","BRIGHTNESS","RESOLUTION AND SIZE","DEFAULT","SOUND","MUSIC","DIALOG","FX","DIFFICULTY"},
        {"ESPAÑOL","INGLÉS","GALEGO", "IDIOMA","IDIOMAS DO SISTEMA","XOGO","IMAXE","VOLUME","MANDO","BRILANCIA","RESOLUTION AND SIZE","PREDETERMINADO","SON","MÚSICA","DÍALOGO","FX","DIFICULTADE"}
    };

    void Start()
    {
        i = PlayerPrefs.GetInt("Idioma", 0);
        ActualizarTextos();
    }



    public void ActualizarTextos()
    {
        botonEspañolText.text = matrizIdiomas[i, 0];
        botonInglesText.text = matrizIdiomas[i, 1];
        botonGallegoText.text = matrizIdiomas[i, 2];
        botonIDIOMAText.text = matrizIdiomas[i, 3];
        IdiomaSistemaText.text = matrizIdiomas[i, 4];
        JugabilidadText.text = matrizIdiomas[i, 5];
        ImagenText.text = matrizIdiomas[i, 6];
        VolumenText.text = matrizIdiomas[i, 7];
        MandoText.text = matrizIdiomas[i, 8];
        BrilloText.text = matrizIdiomas[i, 9];
        ResolucionText.text = matrizIdiomas[i, 10];
        PredeterminadoText.text = matrizIdiomas[i, 11];
        SonidoText.text = matrizIdiomas[i, 12];
        MusicaText.text = matrizIdiomas[i, 13];
        DialogosText.text = matrizIdiomas[i, 14];
        FxText.text = matrizIdiomas[i, 15];
        DificultadText.text = matrizIdiomas[i, 16];

    }
    public void Espanol()

    {
        i = 0;
        ActualizarTextos();
    }
    public void Ingles()

    {
        i = 1;
        ActualizarTextos();
    }
    public void Galego()

    {
        i = 2;
        ActualizarTextos();
    }
        
}


