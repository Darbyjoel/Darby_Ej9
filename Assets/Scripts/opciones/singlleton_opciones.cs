using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UIElements;


public class singlleton_opciones : MonoBehaviour
{
 
    public static singlleton_opciones instance;


    void Awake()
    {


        if (instance == null)
        {

            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        {

        }
    }
   
    
}    