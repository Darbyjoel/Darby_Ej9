using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class CambioEscena : MonoBehaviour

{
     void Start()
    {
        
        
    }
     void Update()
    {
      
    }
    //Manejador de escena para cambiar comunicado por el parametro sting para poder crear un campo de texto y decir a que escena ir
    public void cambioEscena(string nombreEscena)
       
    {
        SceneManager.LoadScene(nombreEscena);
        
    }
    //El SceneManager.LoadScene sirve para darle la orden de cerrar la escena actual y abrir la que le pido enel campo de texto. pss cree dos para poder simular un vboton de restar en opciones.
    public void cambioConfiguracion(string nombreEscena)

    {
        SceneManager.LoadScene(nombreEscena);

    }

    


}
