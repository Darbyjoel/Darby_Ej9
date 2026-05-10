using UnityEngine;
using UnityEngine.UI;

public class resolucion : MonoBehaviour
{
    public Toggle toggle;

    private void Start()
    {
        if (Screen.fullScreen) 
        { toggle.isOn = true; }
    }

}
