using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
   
    void start()
    {
        GameObject[] balas = GameObject.FindGameObjectsWithTag("bala");
        GameObject canon = GameObject.FindGameObjectWithTag("Canon");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bala"))
        {
            Debug.Log("Ouchi");
        }
        Renderer renderer = this.GetComponent<Renderer>();
        Color randomColor = new Color(
           Random.Range(0f, 1f), // Valor aleatorio para el rojo.
           Random.Range(0f, 1f), // Valor aleatorio para el verde.
           Random.Range(0f, 1f));
        renderer.material.color = randomColor;
    }
}
