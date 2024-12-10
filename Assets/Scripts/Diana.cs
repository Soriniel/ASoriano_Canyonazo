using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diana : MonoBehaviour
{
    bool fase1 = true; //cambio de fase
    bool fase2 = false;
    bool fase3 = false;
    bool fase4 = false;
    int velocidadRotacion = 10;
    

    void Start()
    {
        GameObject[] balas = GameObject.FindGameObjectsWithTag("bala");
        GameObject canon = GameObject.FindGameObjectWithTag("Canon");

    }

    void Update()
    {
        if (fase2 == true) //inicio fase 2
        {
            Renderer renderer = this.GetComponent<Renderer>();
            Color randomColor = new Color(
               Random.Range(0f, 1f), // Valor aleatorio para el rojo.
               Random.Range(0f, 1f), // Valor aleatorio para el verde.
               Random.Range(0f, 1f));
            renderer.material.color = randomColor;
        }

        if (fase3 == true) //inicio fase 3
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + velocidadRotacion * Time.deltaTime, transform.rotation.eulerAngles.z);
        }

        if (fase4 == true) //inicio fase 4
        {
            Destroy(this.gameObject);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        

        if (fase1 == true) //cambio fase 2
        {
            fase1 = false;
            fase2 = true;
        }

        else if (fase2 == true) //cambio fase 3
        {
            fase2 = false;
            fase3 = true;
        }

        else if (fase3 == true) //cambio fase 4
        {
            fase3 = false;
            fase4 = true;
        }
    }
}