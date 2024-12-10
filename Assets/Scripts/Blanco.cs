using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blanco : MonoBehaviour
{

    public GameObject bala;
    GameObject balas;
    Vector3 posicionInicial;
    public GameObject balaPrefab;
    public GameObject canon;

    void Start()
    {
        bala = GameObject.Find("Bala");
        posicionInicial = bala.transform.position;
        balaPrefab = Resources.Load<GameObject>("Bala");
        GameObject canon = GameObject.Find("Canon");
        GameManager gameManager = FindObjectOfType<GameManager>();

    }

    private void Update()
    {
        if (balas != null)
        {
            float dist = Vector3.Distance(balas.transform.position, transform.position);
            int cerca = 10;

            if (cerca > dist)

            {
                Renderer renderer = canon.GetComponent<Renderer>();
                Color randomColor = new Color(
                   Random.Range(0f, 1f), // Valor aleatorio para el rojo.
                   Random.Range(0f, 1f), // Valor aleatorio para el verde.
                   Random.Range(0f, 1f));
                renderer.material.color = randomColor;

            }
        }
    }
    private void OnMouseDown()
    {
        // Instanciar la bala en la posición inicial guardada
        balas = Instantiate(balaPrefab, posicionInicial, transform.rotation);
        // Asegúrate de que la bala tenga un Rigidbody para moverse
        Rigidbody rb = balas.GetComponent<Rigidbody>();

        Renderer renderer = balas.GetComponent<Renderer>();
        Color randomColor = new Color(
           Random.Range(0f, 1f), // Valor aleatorio para el rojo.
           Random.Range(0f, 1f), // Valor aleatorio para el verde.
           Random.Range(0f, 1f));
        renderer.material.color = randomColor;

        float tamaño = Random.Range(0.5f, 5f); // Tamaño Aleatorio
        balas.transform.localScale = new Vector3(tamaño, tamaño, tamaño); // Convierte las bolas en un tamaño aleatorio

        float velocidad = Random.Range(10f, 200f);

        if (rb != null)
        {
            // Usa una dirección fija para disparar (por ejemplo, hacia adelante en el espacio global)

            Vector3 direccionDeDisparo = new Vector3(-1f, 1f, 0f).normalized; // o también podrías usar un Vector3 fijo, como Vector3.forward si quieres disparar hacia el frente global
            rb.velocity = direccionDeDisparo * velocidad;

        }

        GameManager.IncNumBalas(); //incrementa el numero de balas
    }
}
