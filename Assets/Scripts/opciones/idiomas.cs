using TMPro;
using UnityEngine;
// using static Unity.VisualScripting.Icons;

public class idiomas : MonoBehaviour
{
    public TextMeshProUGUI botonEspañolText;
    public TextMeshProUGUI botonInglesText;
    public TextMeshProUGUI botonGallegoText;
    public TextMeshProUGUI botonLenguajeText;



    private int i = 0;

    public TMP_Dropdown dropdown;

    private string[,] matrizIdiomas = new string[3, 4]
    {
        {"catellano","Ingles","Gallego", "Idioma" },
        {"Spanish","English","Galician" , "language"},
        { "Espanhol","Inghlés","Gallego","linguaxe" }
        
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
        botonLenguajeText.text = matrizIdiomas[i, 3];





        dropdown.options[0].text = matrizIdiomas[i, 0];
        dropdown.options[1].text = matrizIdiomas[i, 1];
        dropdown.options[2].text = matrizIdiomas[i, 2];
    
        dropdown.RefreshShownValue();

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
    public void lenguaje()

    {
        i = 3;

        ActualizarTextos();
    }


    public void MenuDropDown()
    {
        i = dropdown.value;
        PlayerPrefs.SetInt("Idioma", i);
        PlayerPrefs.Save();
        ActualizarTextos();
    }
        
    }


