using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject scenaGameOver;

    [ContextMenu("Aumenta Puntaje")]
    public void incrementPuntaje(int numero)
    {
        playerScore += numero;
        scoreText.text = playerScore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void activeGameOver()
    {
        scenaGameOver.SetActive(true);
    }
}
