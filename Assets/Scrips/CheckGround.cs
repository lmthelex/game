using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour  
{
    public static bool isGround; //contacto--- static porque la variable se puede utilizar en otros scrips

    private void OnTriggerEnter2D(Collider2D collision)  //cuando el objeto entra en otro objeto
    {
        isGround = true;
    }

    private void OnTriggerExit2D(Collider2D collision)  // cuando sale
    {
        isGround=false;
    }

}
