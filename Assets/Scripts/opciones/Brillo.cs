
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


    public void Pantalla_BrilloEntra(GameObject panelAActivar)
    {
        Text_Imagen.SetActive(false); 

        Text_Volumen.SetActive(true);
        Text_Jugabilidad.SetActive(true);
        Text_Idiomas.SetActive(true);
    }

    public GameObject[] todosLosPaneles; 

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
   


