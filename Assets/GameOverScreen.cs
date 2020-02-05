using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScreen : MonoBehaviour
{
    [Header("Buttons")]
    public Button replayButton;
    public Button BackToMenuButton;
    [Header("Text")]
    public TextMeshPro playerWonText;

    private void Start()
    {
        DisplayPlayerWonText();
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(1);

        GameObject sceneManager = GameObject.FindWithTag("GameController");
        GameManagerScript gameScript = sceneManager.GetComponent<GameManagerScript>();

        gameScript.mainGameTimer = 300;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void DisplayPlayerWonText()
    {
        GameObject gameManager = GameObject.Find("gameManager");
        GameManagerScript gameManagerScript = gameManager.GetComponent<GameManagerScript>();

        playerWonText.text = "Player " + gameManagerScript.winner + "won"; 
    }
}
