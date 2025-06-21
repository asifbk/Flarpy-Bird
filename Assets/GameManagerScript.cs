using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject startButton;
    private bool gameStarted = false;

    void Start()
    {
        Time.timeScale = 0f; // Pause the game
        startButton.SetActive(true);
    }

    public void StartGame()
    {
        Time.timeScale = 1f; // Resume the game
        gameStarted = true;
        startButton.SetActive(false);
    }
}
