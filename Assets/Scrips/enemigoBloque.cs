using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigoBloque : MonoBehaviour
{
    private int collisionCount = 0; // Contador de colisiones

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Player Damage");
            Destroy(collision.gameObject);
        }
        else if (collision.transform.CompareTag("Bullet"))
        {
            Debug.Log("Bullet Hit");
            Destroy(collision.gameObject); // Destruir el proyectil

            collisionCount++; // Incrementar el contador de colisiones
            if (collisionCount > 2)
            {
                Debug.Log("Block Destroyed");
                Destroy(gameObject); // Destruir el bloque enemigo
            }
        }
    }
}