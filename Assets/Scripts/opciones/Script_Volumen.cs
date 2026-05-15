using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Script_Volumen : MonoBehaviour
{
   public AudioMixer mixer;
    public Slider sliderMusica;
    void Start()
    {
        float volumenGuardado = PlayerPrefs.GetFloat("Menu_opciones", 1F);
        sliderMusica.value=volumenGuardado;
        CambiarVolumenMusica(volumenGuardado);
        sliderMusica.onValueChanged.AddListener(CambiarVolumenMusica);
    }

    // Update is called once per frame
    void CambiarVolumenMusica(float valor)
    {
        if (valor < 0.001f) valor = 0.0001f;
        float dB = Mathf.Log10(valor) * 20f;
        mixer.SetFloat("Menu_opciones", dB);
        PlayerPrefs.SetFloat("Menu_opciones", valor);
        PlayerPrefs.Save();
    }
}
