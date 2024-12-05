using TMPro.Examples;
using UnityEngine;

public class Verde : MonoBehaviour
{
    public GameObject bala;
    GameObject balas;
    Vector3 posicionInicial;
    public GameObject balaPrefab;
    public float velocidad = 30f;
    public GameObject canon;

    void Start()
    {
        bala = GameObject.Find("Bala");
        posicionInicial = bala.transform.position;
        balaPrefab = Resources.Load<GameObject>("Bala");
        GameObject canon = GameObject.Find("Canon");
        GameManager gameManager = FindObjectOfType<GameManager>();

    }


    void Update()
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
        if (rb != null)
        {
            // Usa una dirección fija para disparar (por ejemplo, hacia adelante en el espacio global)
            
            Vector3 direccionDeDisparo = new Vector3(-1f, 1f, 0f).normalized; // o también podrías usar un Vector3 fijo, como Vector3.forward si quieres disparar hacia el frente global
            rb.velocity = direccionDeDisparo * velocidad;

        }

        GameManager.IncNumBalas();


    }
}