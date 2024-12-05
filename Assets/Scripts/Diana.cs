using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diana : MonoBehaviour
{
    bool fase1 = true;
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
        if (fase2 == true)
        {
            Renderer renderer = this.GetComponent<Renderer>();
            Color randomColor = new Color(
               Random.Range(0f, 1f), // Valor aleatorio para el rojo.
               Random.Range(0f, 1f), // Valor aleatorio para el verde.
               Random.Range(0f, 1f));
            renderer.material.color = randomColor;
        }

        if (fase3 == true)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + velocidadRotacion * Time.deltaTime, transform.rotation.eulerAngles.z);
        }

        if (fase4 == true)
        {
            Destroy(this.gameObject);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        

        if (fase1 == true)
        {
            fase1 = false;
            fase2 = true;
        }

        else if (fase2 == true)
        {
            fase2 = false;
            fase3 = true;
        }

        else if (fase3 == true)
        {
            fase3 = false;
            fase4 = true;
        }
    }
}