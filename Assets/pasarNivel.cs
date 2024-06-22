using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour;
public class gameObject : MonoBehaviour;
{
    public static int Iteration = 0;

    private void Start()
    {
        if (Iteration >= 1)
        {
            SpawnEnemy();
        }
    }

    public void SpawnEnemy()
    {

    }

    public void LevelUp()
    {
        Iteration++;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}