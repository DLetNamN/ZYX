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
    public TextMeshProUGUI playerWonText;
    public GameManagerScript gamehandlerscript;
    private void Start()
    {
        DisplayPlayerWonText();
    }

    public void ReplayGame()
    {
        GameObject sceneManager = GameObject.FindWithTag("GameController");
        GameManagerScript gameScript = sceneManager.GetComponent<GameManagerScript>();

        gameScript.mainGameTimer = 300;

        SceneManager.LoadScene(1);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void DisplayPlayerWonText()
    {
        GameObject gameManager = GameObject.Find("GameManager");
        gamehandlerscript = gameManager.GetComponentInChildren<GameManagerScript>();

        playerWonText.text = "Player " + gamehandlerscript.winner + "won"; 
    }
}
