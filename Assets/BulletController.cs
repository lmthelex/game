using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletControllerScript : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float damageDealt;
    [SerializeField] GameObject gun;
    int lifetime;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
 
    }
}
