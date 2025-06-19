using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playScore;
    public int highScore;
    public int score;

   
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource birdsSFX;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playScore = playScore + scoreToAdd;
        scoreText.text = playScore.ToString();
        birdsSFX.Play();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //bird crash
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        
    }
}
