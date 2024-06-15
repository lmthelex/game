using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladrilloscript : MonoBehaviour
{
    public logicScript logic;
    public Rigidbody2D ladrilloRigido;
    public float Velocidad;
    private bool vida = true;

    // Start is called before the first frame update
    void Start()
    {
       // logic = GameObject.FindGameObjectWithTag("Logica Chamo").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ladrilloRigido.velocity = Vector2.up * Velocidad;
        }
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    ladrilloRigido.velocity = Vector2.right * 10;
        //}
        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    ladrilloRigido.velocity = Vector2.left * 10;
        //}
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //logic.activeGameOver();
        //vida = false;
    }
    
}
