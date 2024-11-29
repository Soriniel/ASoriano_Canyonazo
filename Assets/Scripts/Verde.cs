using UnityEngine;

public class Verde : MonoBehaviour
{
    GameObject bala;
    Vector3 posicionInicial;
    public GameObject balaPrefab;
    public float velocidad = 30f;

    void Start()
    {
        bala = GameObject.Find("Bala");
        posicionInicial = bala.transform.position;
        balaPrefab = Resources.Load<GameObject>("Bala");
        
    }

    private void OnMouseDown()
    {
        

        // Instanciar la bala en la posición inicial guardada
        GameObject balas = Instantiate(balaPrefab, posicionInicial, transform.rotation);

        // Asegúrate de que la bala tenga un Rigidbody para moverse
        Rigidbody rb = balas.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Usa una dirección fija para disparar (por ejemplo, hacia adelante en el espacio global)
            
            Vector3 direccionDeDisparo = new Vector3(-1f, 1f, 0f).normalized; // o también podrías usar un Vector3 fijo, como Vector3.forward si quieres disparar hacia el frente global
            rb.velocity = direccionDeDisparo * velocidad;

        }


    }
}