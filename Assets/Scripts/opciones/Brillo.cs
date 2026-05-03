using UnityEngine;
using UnityEngine.UI;

public class Brillo : MonoBehaviour
{
    public Image Panel_Brillo;
    public Slider Slider_Brillo;

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
        c.a = 1f - valor/10;
        Panel_Brillo.color = c;
        PlayerPrefs.SetFloat("Brillo", valor);
        PlayerPrefs.Save();
    }

}
