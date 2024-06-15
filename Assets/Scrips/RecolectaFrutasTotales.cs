using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecolectaFrutasTotales : MonoBehaviour
{
    private void Update()
    {
        TotalColectaFrutas();
    }

    public void TotalColectaFrutas()
    {
        if(transform.childCount == 0)
        {
            Debug.Log("No quedan mas frutas");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }



}
