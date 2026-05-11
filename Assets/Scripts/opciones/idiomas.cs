using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.Rendering;
using UnityEngine.Rendering.VirtualTexturing;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.DebugUI;

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
    public TextMeshProUGUI ResolucionTamañoText;
    public TextMeshProUGUI PredeterminadoText;
    public TextMeshProUGUI SonidoText;
    public TextMeshProUGUI MusicaText;
    public TextMeshProUGUI DialogosText;
    public TextMeshProUGUI FxText;
    public TextMeshProUGUI DificultadText;
    public TextMeshProUGUI Resoluciontext;
    public TextMeshProUGUI PantallaCompletatext;
    public TextMeshProUGUI failtext;
    public TextMeshProUGUI Mediotext;
    public TextMeshProUGUI Dificiltext;
    public TextMeshProUGUI MuyDificiltext;
    public TextMeshProUGUI VolverOptiontext; 
    public TextMeshProUGUI CreditosOptiontext;
    public TextMeshProUGUI Restaurartext;
    public TextMeshProUGUI OpcionesHeadtext;



    private int i = 0;
    private string[,] matrizIdiomas = new string[3, 27]
    {
       {"CASTELLANO","ÍNGLES","GALLEGO", "IDIOMA","IDIOMAS DEL SISTEMA","JUGABILIDAD","IMAGEN","VOLUMEN","MANDO","BRILLO","RESOLUCIÓN Y TAMAÑO","PREDETERMINADO","SONIDO","MÚSICA","DÍALOGO","FX","DIFICILTAD","RESOLUCION","PANTALLA COMPLETA","FÁCIL","MEDIO","DIFICIL","MUY DIFICIL","VOLVER","CREDITOS","RESTAURAR","OPCIONES"},
       {"SPANISH","ENGLISH","GALICIAN", "LANGUAGE","SYSTEM LANGUAGES","GAMEPLAY","IMAGE","VOLUME","CONTROLLER","BRIGHTNESS","RESOLUTION AND SIZE","DEFAULT","SOUND","MUSIC","DIALOG","FX","DIFFICULTY", "RESOLUTION","FULL SCREEN","EASY","MEDIUM","DIFÍCULT", "VERY DIFÍCULT","BACK", "CREDITS", "RESTORE", "OPTIONS" },
        {"ESPAÑOL","INGLÉS","GALEGO", "IDIOMA","IDIOMAS DO SISTEMA","XOGO","IMAXE","VOLUME","MANDO","BRILANCIA","RESOLUTION AND SIZE","PREDETERMINADO","SON","MúSICA","DÍALOGO","FX","DIFICULTADE","RESOLUCIÓN","PANTALLA COMPLETA","FÁCIL", "MEDIO","DIFÍCIL", "MOI DIFICIL","VOLVER", "CREDITOS", "RESTAURAR", "OPCIONS"}
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
        ResolucionTamañoText.text = matrizIdiomas[i, 10];
        PredeterminadoText.text = matrizIdiomas[i, 11];
        SonidoText.text = matrizIdiomas[i, 12];
        MusicaText.text = matrizIdiomas[i, 13];
        DialogosText.text = matrizIdiomas[i, 14];
        FxText.text = matrizIdiomas[i, 15];
        DificultadText.text = matrizIdiomas[i, 16];
        Resoluciontext.text = matrizIdiomas[i, 17];
        PantallaCompletatext.text = matrizIdiomas[i, 18];
        failtext.text = matrizIdiomas[i, 19];
        Mediotext.text = matrizIdiomas[i, 20];
        Dificiltext.text = matrizIdiomas[i, 21];
        MuyDificiltext.text = matrizIdiomas[i, 22];
        VolverOptiontext.text = matrizIdiomas[i, 23];
        CreditosOptiontext.text = matrizIdiomas[i, 24];
        Restaurartext.text = matrizIdiomas[i, 25];
        OpcionesHeadtext.text = matrizIdiomas[i, 26];

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
        //Guardamos el valor de 'i' en la memoria con la llave "Idioma"
    PlayerPrefs.SetInt("Idioma", i);

        //Fuerza el guardado en el disco
        PlayerPrefs.Save();

        //Actualizamos los textos visuales
        ActualizarTextos();

        Debug.Log("Idioma guardado: " + i);
    }

}


