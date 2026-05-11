using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.Rendering;
using UnityEngine.Rendering.VirtualTexturing;
using static UnityEngine.UI.GridLayoutGroup;

public class iDIOMA_iNICIO: MonoBehaviour
{
    public TextMeshProUGUI jugarText;
    public TextMeshProUGUI opcionesText;
    public TextMeshProUGUI salirText;
    public TextMeshProUGUI CargarPartidaText;
    public TextMeshProUGUI UsuarioHeadText;
    public TextMeshProUGUI JugadorLeerText;
    public TextMeshProUGUI CorreoLeerText;
    public TextMeshProUGUI PreguntaSalirJuegoText;
    public TextMeshProUGUI VolverJuegoText;
    public TextMeshProUGUI SalirJuegoText;
    public TextMeshProUGUI SalirdeljuegoHeadText;
    public TextMeshProUGUI CargarPartidaHeadText;
    public TextMeshProUGUI TiempojugadoUnoText;
    public TextMeshProUGUI TiempojugadoDosText;
    public TextMeshProUGUI TiempojugadoTresText;
    public TextMeshProUGUI TiempojugadoCuatroText;
    public TextMeshProUGUI NombreUnoText;
    public TextMeshProUGUI NombreDosText;
    public TextMeshProUGUI NombreTresText;
    public TextMeshProUGUI NombreCuatroText;
    public TextMeshProUGUI NuevaUnoText;
    public TextMeshProUGUI NuevaDosText;
    public TextMeshProUGUI NuevaTresText;
    public TextMeshProUGUI NuevaCuatroText;
    public TextMeshProUGUI BorrarUnoText;
    public TextMeshProUGUI BorrarDosText;
    public TextMeshProUGUI BorrarTresText;
    public TextMeshProUGUI BorrarCuatroText;
    public TextMeshProUGUI JugarSalirCargarText;
    public TextMeshProUGUI VolverSalirCargarText;
    public TextMeshProUGUI TiendaHeadText;
    public TextMeshProUGUI UpssText;
    public TextMeshProUGUI ParaínformacionText;
    public TextMeshProUGUI NombreText;
    public TextMeshProUGUI VolverText;





    private int i = 0;
    private string[,] matrizIdiomas = new string[3, 35]
    {
       {"JUGAR","OPCIONES","SALIR","cargar partida","USUARIO","JUGADOR","CORREO","¿ESTÁS SEGURO DE SALIR DEL JUEGO?","VOLVER","SALIR","SALIR DEL JUEGO","CARGAR PARTIDA","TIEMPO JUGADO","TIEMPO JUGADO","TIEMPO JUGADO","TIEMPO JUGADO","NOMBRE","NOMBRE","NOMBRE","NOMBRE","NUEVA","NUEVA","NUEVA","NUEVA","BORRAR","BORRAR","BORRAR","BORRAR","JUGAR","VOLVER","TIENDA","UPSS......ESTO AÚN NO ESTA DISPONIBLE","PARA TENER MÁS INFORMACIÓN DEJA AQUÍ TU CORREO","NOMBRE","VOLVER"},
      {"PLAY","OPTIONS","EXIT","load game","USER","PLAYER","EMAIL","ARE YOU SURE YOU WANT TO EXIT THE GAME?","BACK","EXIT","EXIT GAME","LOAD GAME","PLAY TIME","PLAY TIME","PLAY TIME","PLAY TIME","NAME","NAME","NAME","NAME","NEW","NEW","NEW","NEW","DELETE","DELETE","DELETE","DELETE","PLAY","BACK","STORE","UPSS......THIS IS NOT AVAILABLE YET","FOR MORE INFORMATION LEAVE YOUR EMAIL HERE","NAME","BACK"},
        {"XOGAR","OPCIONS","SAIR","cargar partida","USUARIO","XOGADOR","CORREO","¿ESTAS SEGURO DE QUE QUERES SAÍR DO XOGO?","VOLVER","SAIR","SAIR DO XOGO","CARGAR PARTIDA","TEMPO XOGADO","TEMPO XOGADO","TEMPO XOGADO","TEMPO XOGADO","NOME","NOME","NOME","NOME","NOVA","NOVA","NOVA","NOVA","BORRAR","BORRAR","BORRAR","BORRAR","XOGAR","VOLVER","TENDA","UPSS......ISTO AINDA NON ESTÁ DISPOÑIBLE","PARA TER MÁIS INFORMACIÓN DEIXA AQUÍ O TEU CORREO","NOME","VOLVER"}
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
        CargarPartidaText.text = matrizIdiomas[i, 3];
        UsuarioHeadText.text = matrizIdiomas[i, 4];
        JugadorLeerText.text = matrizIdiomas[i, 5];
        CorreoLeerText.text = matrizIdiomas[i, 6];
        PreguntaSalirJuegoText.text = matrizIdiomas[i, 7];
        VolverJuegoText.text = matrizIdiomas[i, 8];
        SalirJuegoText.text = matrizIdiomas[i, 9];
        SalirdeljuegoHeadText.text = matrizIdiomas[i, 10];
        CargarPartidaHeadText.text = matrizIdiomas[i, 11];
        TiempojugadoUnoText.text = matrizIdiomas[i, 12];
        TiempojugadoDosText.text = matrizIdiomas[i, 13];
        TiempojugadoTresText.text = matrizIdiomas[i, 14];
        TiempojugadoCuatroText.text = matrizIdiomas[i, 15];
        NombreUnoText.text = matrizIdiomas[i, 16];
        NombreDosText.text = matrizIdiomas[i, 17];
        NombreTresText.text = matrizIdiomas[i, 18];
        NombreCuatroText.text = matrizIdiomas[i, 19];
        NuevaUnoText.text = matrizIdiomas[i, 20];
        NuevaDosText.text = matrizIdiomas[i, 21];
        NuevaTresText.text = matrizIdiomas[i, 22];
        NuevaCuatroText.text = matrizIdiomas[i, 23];
        BorrarUnoText.text = matrizIdiomas[i, 24];
        BorrarDosText.text = matrizIdiomas[i, 25];
        BorrarTresText.text = matrizIdiomas[i, 26];
        BorrarCuatroText.text = matrizIdiomas[i, 27];
        JugarSalirCargarText.text = matrizIdiomas[i, 28];
        VolverSalirCargarText.text = matrizIdiomas[i, 29];
        TiendaHeadText.text = matrizIdiomas[i, 30];
        UpssText.text = matrizIdiomas[i, 31];
        ParaínformacionText.text = matrizIdiomas[i, 32];
        NombreText.text = matrizIdiomas[i, 33];
        VolverText.text = matrizIdiomas[i, 34];


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


