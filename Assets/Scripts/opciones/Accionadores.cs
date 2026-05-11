using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Accionadores : MonoBehaviour

{
    
    //Con Public hacemos la variable visible para desde afuera del script, con con tmp_text sirve parapara referenciar a un componente textmeshpro y el textoValortoggle hace referecnai a que es un componente toggle
    [Header("Toggle")]
    public TMP_Text textoValorToggle;

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

    [Header("sliderBrillo")]
    public Slider sliderBrillo;
    public TMP_Text textoValorBrillo;

    //Con Public hacemos la variable visible para desde afuera del script, con Dropdown le señalo que el componente es de tipo Dropdown y con con tmp_text sirve parapara referenciar a un componente textmeshpro. Lo hice para un boton de dificultad y el de Resolución
    [Header("DropdownDificultad")]
    public TMP_Dropdown miDropdownDificultad;
    public TMP_Text textoValorDificultad;

    [Header("DropdownResolucion")]
    public TMP_Dropdown miDropdownResolucion;
    public TMP_Text textoValorResolucion;





    //Este texto sirve para que el texto del menú cambie automáticamente al nombre del objeto que el jugador ha seleccionado; el !toggle.isOn sirve para dar una comprobacion de que el interrructor esta apagado y return  para que si el toggle esta apagado la función se detenga. TextValor Sirve para que aceda a la proppiedad de la variable que se declara arriba y toggle.gameObject.name  optiene el nombre del objeto en el  Hierachy
    public void leerToggle(Toggle toggle)
    {
        if (!toggle.isOn) return;
        textoValorToggle.text = toggle.gameObject.name;
    }
    //Aqui el codigo hace que el textmeshpro se vincule al Toggle y  que según lo que le apretemos haga que se active ene le texmexhpro; lo use para un botones de seleción de resolucón
    public void LeerToggle2(string toggle)
    {
        textoValorToggle.text = toggle;
    }

    //Aqui vinculamos el textmeshpro con el Input field, haciendo que el texto escrito en el imput field se proyecte en el textmeshpro vinculado; lo use para que el ususaio ponga su nombre en su perfil de guardado
   

    // Aqui vinculamos el textmeshpro con el slider, haciendo que el valor del movimiento del slider  se proyecte en el textmeshpro vinculado
    public void LeerImputMusica ()
    {
        float valor = sliderMusica.value;
        textoValorMusica.text = valor.ToString();
    }
    
    //Aqui Y en el anterior cree codigos con la misma funcion pero con valores distintos para que el programa los  detectara y pudiera craer vareios slider en una msiama escena y que tenga un textmeshpro asignado segun mi eleccion
    public void LeerImputDialogos()
    {
        float valor = sliderDialogos.value;
        textoValorDialogos.text = valor.ToString();
    }
    public void LeerImputBrillo()
    {
        float valor = sliderBrillo.value;
        textoValorBrillo.text = valor.ToString();
    }
    
    public void LeerImputFx()
    {
        float valor = sliderFx.value;
        textoValorFx.text = valor.ToString();
    }
    //Aqui vinculamos el textmeshpro con Dropdown haciendo que opció selecionada en el Dropdown se proyecte en el textmeshpro vinculado; lo use para crear un boton de dificultad.
    public void LeerDropdownDificultad()
    {
        float valor = miDropdownDificultad.value;
        textoValorDificultad.text = valor.ToString();
    }
    public void LeerDropdown()
    {
        float valor = miDropdownResolucion.value;
        textoValorResolucion.text = valor.ToString();
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


