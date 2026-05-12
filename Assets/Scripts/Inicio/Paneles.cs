using JetBrains.Annotations;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class Paneles : MonoBehaviour
{

    // int idanimacion sirve para grabar como un numero entero en el menu para saber cual es el que esta abierto y que menu debe cerrar. Las para generar casillas para cada animación.
    int idAnimacion;

    public Animator menuTienda;
    public Animator menuSalir;
    public Animator menuCargar;
    public Image Panel_Brillo;

    [Header("InputJugadorUno")]
    public TMP_InputField inputJugadorUno;
    public TMP_Text textoInputNombreUsuario;
   

    [Header("imputCorreo")]
    public TMP_InputField CoreeoJugador;
    public TMP_Text textoCoreeoJugador;

    [Header("CargarPartida")]
    public Toggle PalomaPartidaUno;
    public Toggle PalomaPartidaDos;
    public Toggle PalomaPartidaTres;
    public Toggle PalomaPartidaCuatro;
    


    public void Start()
    {
        float brilloGuardado = PlayerPrefs.GetFloat("Brillo", 100f);
        CambiarBrillo(brilloGuardado);
        string nombreGuardado = PlayerPrefs.GetString("NombreJugador", "Jugador");

        textoInputNombreUsuario.text = nombreGuardado;
        inputJugadorUno.text = nombreGuardado;
        int casillaGuardada = PlayerPrefs.GetInt("CargarActiva", 0);

        PalomaPartidaUno.isOn = (casillaGuardada == 1);
        PalomaPartidaDos.isOn = (casillaGuardada == 2);
        PalomaPartidaTres.isOn = (casillaGuardada == 3);
        PalomaPartidaCuatro.isOn = (casillaGuardada == 4);

    }
    public void CambiarBrillo(float valor) 
    {
        Color c = Panel_Brillo.color;
        c.a = 1f - valor / 10;
        Panel_Brillo.color = c;
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

   
    public void EntraMenu()
    {
        switch (idAnimacion)
        {
            case 1:
                menuTienda.Play("MenuTienda");
                break;
            case 2:

                menuSalir.Play("MenuPregunta");
                break;
            case 3:
                menuCargar.Play("MenuCargaEntra");
                break;         
        }
    }
    public void SalirMenu()
    {
        switch (idAnimacion)
        {
            case 1:
                menuTienda.Play("MenuTiendaSalir");
                break;
            case 2:
                menuSalir.Play("MenuPreguntaSalir");
                break;
            case 3:

                menuCargar.Play("MenuCargarSalir");
                break; 
        }
    }
   
 
    public GameObject[] todosLosPaneles;

    public void AbrirPanelEspecifico(int indice)
    {
        for (int i = 0; i < todosLosPaneles.Length; i++)
        {

            todosLosPaneles[i].SetActive(i == indice);
        }
    }

    
    public void ActivarPajaroUno()
    {
        PalomaPartidaUno.isOn = true;
        PlayerPrefs.SetInt("CargarActiva", 1);
        PlayerPrefs.Save();
    }
    public void ActivarPajaroDos()
    {
        PalomaPartidaDos.isOn = true;
        PlayerPrefs.SetInt("CargarActiva", 2);
        PlayerPrefs.Save();
    }
    public void ActivarPajaroTres()
    {
        PalomaPartidaTres.isOn = true;
        PlayerPrefs.SetInt("CargarActiva", 3);
        PlayerPrefs.Save();
    }
    public void ActivarPajaroCuatro()
    {
        PalomaPartidaCuatro.isOn = true;
        PlayerPrefs.SetInt("CargarActiva", 4);
        PlayerPrefs.Save();
    }

    public void LeerInputJugadorUno()
    {
        string texto = inputJugadorUno.text;
        textoInputNombreUsuario.text = texto;
        PlayerPrefs.SetString("NombreJugador", texto);
        PlayerPrefs.Save();
    }
    public void imputCorreo()
    {
        string texto = CoreeoJugador.text;
        textoCoreeoJugador.text = texto;
        PlayerPrefs.SetString("CorreoJugador", texto);
        PlayerPrefs.Save();
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


   