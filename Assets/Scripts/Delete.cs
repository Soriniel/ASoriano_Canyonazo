using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    // Etiqueta asignada a las balas.
    private void Start()
    {
        GameManager gameManager = FindObjectOfType<GameManager>();
    }

    private void OnMouseDown()
    {
        // Encuentra todos los objetos con la etiqueta "Bala".
        GameObject[] balas = GameObject.FindGameObjectsWithTag("bala");


            foreach (GameObject bala in balas)
            {
                Destroy(bala); // Destruye cada bala encontrada.
            }

        GameManager.ResetearBalas(); //Pone en 0 el contador de balas


    }
}
