using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MensajeController : MonoBehaviour
{
    public GameObject WinnerText;
    public GameObject FinText;
    public static GameObject winnerStatic;
    public static GameObject finStatic;

    void Start()
    {
        MensajeController.winnerStatic = WinnerText;
        MensajeController.finStatic = FinText;
        MensajeController.winnerStatic.gameObject.SetActive(false);
        MensajeController.finStatic.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void Mostrar()
    {
        MensajeController.winnerStatic.gameObject.SetActive(true);
        MensajeController.finStatic.gameObject.SetActive(true);
    }
}
