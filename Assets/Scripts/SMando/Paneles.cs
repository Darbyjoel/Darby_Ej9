using JetBrains.Annotations;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;



public class Paneles : MonoBehaviour
{

    // int idanimacion sirve para grabar como un numero entero en el menu para saber cual es el que esta abierto y que menu debe cerrar. Las para generar casillas para cada animación.
    int idAnimacion;
    public Animator menuMando;
    public Animator menuIdioma;
    public Animator menuSalir;
    public Animator menuTienda;
    public Animator menuCargar;
    internal Color color;
    public Image Panel_Brillo;


    public void Start()
    {
        float brilloGuardado = PlayerPrefs.GetFloat("Brillo", 100f);
        CambiarBrillo(brilloGuardado);
    }

    //Esto hace que el metodo aparesca en Unity
    public void BotonCambiaAnimacion(int id)
    {
        // el id ctualiza la indetidad del boton que sera precionado para que se pase la accion contrria. Salir..ejeculata la animación de salida del Menu que estaba abierto. Entrar 
        SalirMenu();
        idAnimacion = id;
        EntraMenu();
       

        //Estos dos codigos son menus de opciones de tipo switch. Cada caso esta vinculado a un numero que lo vincula con el tipo de animación de entrada y de salida que le correspodenria segun su agrupación y número. Y el break le dice que no se vincule con los demas casos
    }

    public void CambiarBrillo(float valor)

    {
        Color c = Panel_Brillo.color;
        c.a = 1f - valor / 10;
        Panel_Brillo.color = c;
    }
    public void EntraMenu()
    {
        switch (idAnimacion)
        {
            case 1:
                menuMando.Play("MenuMandoInicio");
                break;
            case 2:
                menuIdioma.Play("IdiomaAnimacionEntrar");
                break;
            case 3:
                menuSalir.Play("MenuPregunta");
                break;
            case 4:

                menuTienda.Play("MenuTienda");
                break;
            case 5:
                menuCargar.Play("MenuCargaEntra");
                break;
        }
    }
    public void SalirMenu()
    {
        switch (idAnimacion)
        {
            case 1:
                menuMando.Play("MenuMandoSalir");
                break;
            case 2:
                menuIdioma.Play("MenuIdiomaSalida");
                break;
            case 3:
                menuSalir.Play("MenuPreguntaSalir");
                break;
            case 4:
                menuTienda.Play("MenuTiendaSalir");
                break;
            case 5:
                menuCargar.Play("MenuCargarSalir");
                break;


        }
    }
       
    //salir del juego
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Salir();
        }
    }

   public void Salir()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}


   