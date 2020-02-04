using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public int currentScene;

    public GameObject[] gameManager;

    public float mainGameTimer;

    public string playerWhoWon;

    [SerializeField] int player1HP;
    [SerializeField] int player2HP;

    public TextMeshProUGUI timerText;

    private void Start()
    {
        mainGameTimer = 300;
    }

    private void Awake()
    {
        gameManager = GameObject.FindGameObjectsWithTag("GameController");


        if (gameManager.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        if (currentScene == 1)
        {
            Timer();

            if (mainGameTimer <= 0)
            {
                WhenTimerIsDone();
            }

            TimerUI();
        }

        currentScene = SceneManager.GetActiveScene().buildIndex;


    }

    public void TimerUI()
    {
        timerText = GameObject.Find("TimerText").GetComponent<TextMeshProUGUI>();

        string minutes = Mathf.Floor(mainGameTimer / 60).ToString("00");

        string seconds = Mathf.Floor(mainGameTimer % 60).ToString("00");

        timerText.text = minutes + ":" + seconds;
    }

    public void WhenTimerIsDone()
    {
        if (currentScene == 1)
        {
            if (player1HP < player2HP)
            {
                playerWhoWon = "2";
            }
            else if (player2HP < player1HP)
            {
                playerWhoWon = "1";
            }
            else if (player1HP == player2HP)
            {
                playerWhoWon = "";
            }

            SceneManager.LoadScene(2);
        }
    }

    public void Timer()
    {
        mainGameTimer -= Time.deltaTime;
    }
}

