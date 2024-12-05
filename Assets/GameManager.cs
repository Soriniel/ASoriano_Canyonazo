using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    static public TextMeshProUGUI numBalasText;
    static int numBalas = 0;

    void Start()
    {
        // Buscar el GO del texto
        GameObject contador = GameObject.Find("Contador");
        numBalasText = contador.GetComponent<TextMeshProUGUI>();

    }

    void Update()
    {
        // De momento nada
        numBalasText.text = "Balas: " + numBalas;
    }

    static public void ResetearBalas()
    {
        numBalas = 0;
    }

    static public void IncNumBalas()
    {
       numBalas++;
    }

    static public void DecNumBalas()
    {
        // Decrementar el n�mero de balas y cambiar el texto del canvas
    }
}
