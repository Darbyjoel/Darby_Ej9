using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Accionadores : MonoBehaviour

{
    
    //Con Public hacemos la variable visible para desde afuera del script, con con tmp_text sirve parapara referenciar a un componente textmeshpro y el textoValortoggle hace referecnai a que es un componente toggle
 

    //Con Public hacemos la variable visible para desde afuera del script, con  Slider le señalo que el componente es de tipo  Slider y con con tmp_text sirve parapara referenciar a un componente textmeshpro  
    [Header("sliderMusica")]
    public Slider sliderMusica;
    public TMP_Text textoValorMusica;

    //Aqui si vemos el codigo en sliderDialogos, SliderMusica, SliderFx y SliderBrillo es muy parecido. Porque aunque cumplen la misma funcion, si les cambio los nombres Unity me permite uasar silder distintos en una misma pantalla para configurar cada apartado por separado.
    [Header("sliderDialogos")]
    public Slider sliderDialogos;
    public TMP_Text textoValorDialogos;


    [Header("sliderFx")] 
    public Slider sliderFx;
    public TMP_Text textoValorFx;

    

    public void Start()
    {
        // 1. Recuperamos el nombre que guardamos antes
        if (PlayerPrefs.HasKey("DificultadSeleccionada"))
        {
            string guardado = PlayerPrefs.GetString("DificultadSeleccionada");

            // 2. Buscamos el objeto por su nombre en la escena
            GameObject objetoGuardado = GameObject.Find(guardado);

            if (objetoGuardado != null)
            {
                // 3. Obtenemos su componente Toggle y lo encendemos
                Toggle toggle = objetoGuardado.GetComponent<Toggle>();
                if (toggle != null)
                {
                    toggle.isOn = true;
                    Debug.Log("dificultad: " + guardado);
                }
            }
        }
    }




    //Este texto sirve para que el texto del menú cambie automáticamente al nombre del objeto que el jugador ha seleccionado; el !toggle.isOn sirve para dar una comprobacion de que el interrructor esta apagado y return  para que si el toggle esta apagado la función se detenga. TextValor Sirve para que aceda a la proppiedad de la variable que se declara arriba y toggle.gameObject.name  optiene el nombre del objeto en el  Hierachy
  public void leerToggle(bool valor)
    {
    if (!valor) return;
    GameObject objetoClicado = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
    if (objetoClicado != null)
        {
        // Guardamos el nombre del objeto (ej: B_Facil) permanentemente
        PlayerPrefs.SetString("DificultadSeleccionada", objetoClicado.name);
        PlayerPrefs.Save();
        Debug.Log("Dificultad guardada internamente: " + objetoClicado.name);
        }
    }   


    // Aqui vinculamos el textmeshpro con el slider, haciendo que el valor del movimiento del slider  se proyecte en el textmeshpro vinculado
    public void leerImputMusica ()
    {
        float valor = sliderMusica.value;
        textoValorMusica.text = valor.ToString();
    }
    
    //Aqui Y en el anterior cree codigos con la misma funcion pero con valores distintos para que el programa los  detectara y pudiera craer vareios slider en una msiama escena y que tenga un textmeshpro asignado segun mi eleccion
    public void leerImputDialogos()
    {
        float valor = sliderDialogos.value;
        textoValorDialogos.text = valor.ToString();
    }


    public void leerImputFx()
    {
        float valor = sliderFx.value;
        textoValorFx.text = valor.ToString();
    }

    public void CambiaMenuPrincipal()
    {
        SceneManager.LoadScene("MenuJuego");
     
            }
    public void CambioMenuVideo()
    {
        SceneManager.LoadScene("EsceneVideo");

    }




}


