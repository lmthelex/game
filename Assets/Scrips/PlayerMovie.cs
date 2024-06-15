using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovie : MonoBehaviour
{
    public float runSpeed = 2;  // velocidad 
    public float jumSpeed = 3;
    Rigidbody2D rb2d;   //hace referencia al rigibody

    //variables para los saltos
    public bool betterJump=false;  //mejor salto
    public float fallMultiplier = 0.5f; //velocidad de salto   
    public float lowJumMultiplier = 1f;  // velocidad de caida

    public SpriteRenderer spritR;
    public Animator animator;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); // guardar los componentes de rigibody en la variable 
    }

    void FixedUpdate()  // para la fisica
    {
        if (Input.GetKey("d") || Input.GetKey("right") ){
            rb2d.velocity = new Vector2(runSpeed, rb2d.velocity.y); // movimiento para la derecha
            spritR.flipX = false;
            animator.SetBool("Run", true);// mientras se dirige hacia la derecha se muestra la animacion de run
        }
        else if (Input.GetKey("a") || Input.GetKey("left")){
            rb2d.velocity = new Vector2(-runSpeed, rb2d.velocity.y);  //movimiento para la izquieda
            spritR.flipX = true;
            animator.SetBool("Run", true);
        }
        else{
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
            animator.SetBool("Run", false);
        }
        if( (Input.GetKey("space") || Input.GetKey("w")) && CheckGround.isGround==true)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumSpeed);
        }
        ///animacion de salto
        if (CheckGround.isGround == false) // si no toca el suelo
        {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }
        if (CheckGround.isGround == true) // si  toca el suelo
        {
            animator.SetBool("Jump", false);
  
        }


        if (betterJump)
        {
            if (rb2d.velocity.y < 0)
            {
                rb2d.velocity += Vector2.up * Physics2D.gravity * (fallMultiplier) * Time.deltaTime; 
            }
            if(rb2d.velocity.y > 0   && !Input.GetKey("space") )
            {
                rb2d.velocity += Vector2.up * Physics2D.gravity * (lowJumMultiplier) * Time.deltaTime;
            }
        }



    }
}
