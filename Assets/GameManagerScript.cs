using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using AAT.HP;

public class GameManagerScript : MonoBehaviour
{
    public int currentScene;

    public GameObject[] gameManager;

    public float mainGameTimer;

    public string playerWhoWon;

    [SerializeField] int player1HP;
    [SerializeField] int player2HP;

    public TextMeshProUGUI timerText;

    public TextMeshProUGUI winner;

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

        PlayerIsDead();
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
            SceneManager.LoadScene(2);
        }
    }

    public void Timer()
    {
        mainGameTimer -= Time.deltaTime;
    }

    public void PlayerIsDead()
    {
        GameObject player1 = GameObject.Find("Player1");
        HP player1hp = player1.GetComponent<HP>();

        player1HP = player1hp.p_hp;

        GameObject player2 = GameObject.Find("Player2");
        HP player2hp = player2.GetComponent<HP>();

        player2HP = player2hp.p_hp;


        if (player1HP < player2HP)
        {
            winner.text = "2";
        }
        else if (player2HP < player1HP)
        {
            winner.text = "1";
        }

        if (player1HP <= 0 || player2HP <= 0)
        {
            GameObject gameOverPanel = GameObject.Find("GameOverPanel");

            gameOverPanel.SetActive(true);
        }
    }
}

