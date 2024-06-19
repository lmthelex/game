using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class Daño : MonoBehaviour
{
    private int collisionCount = 0; // Contador de colisiones

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Player Damage");
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            Debug.Log("Bullet Hit");

            collisionCount++; // Incrementar el contador de colisiones
            if (collisionCount > 2)
            {
                Debug.Log("Block Destroyed");
                Destroy(gameObject); // Destruir el bloque enemigo
            }
        }
    }
}
