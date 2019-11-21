using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    GameObject options;
    GameObject credits;
    GameObject mainMenu;

    void Start()
    {
        options = GameObject.Find("Options");
        credits = GameObject.Find("Credits");
        mainMenu = GameObject.Find("MainMenu");
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OptionsScreen()
    {
        mainMenu.SetActive(false);
        options.SetActive(true);
    }

    public void CreditsScreen()
    {
        mainMenu.SetActive(false);
        credits.SetActive(true);
    }

    public void ExitGame()
    {
        ExitGame();
        print("Exited Game");
    }

    public void BackButton()
    {
        options.SetActive(false);
        credits.SetActive(false);
        mainMenu.SetActive(true);
    }

}
