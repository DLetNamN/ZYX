using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [Header("Canvases")]
    public GameObject options;
    public GameObject credits;
    public GameObject mainMenu;
    [Header("Buttons")]
    public Button creditsBackButton;
    public Button optionsBackButton;
    public Button startGameButton;
    [Header("Sounds")]
    public AudioSource SelectEffect;
    public AudioSource ButtonSoundEffect;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OptionsScreen()
    {
        mainMenu.SetActive(false);
        options.SetActive(true);

        optionsBackButton.Select();
        PlaySelectSound();
    }

    public void CreditsScreen()
    {
        mainMenu.SetActive(false);
        credits.SetActive(true);

        creditsBackButton.Select();
        PlaySelectSound();
    }

    public void ExitGame()
    {
        Application.Quit();
        print("Exited Game");
    }

    public void BackButton()
    {
        options.SetActive(false);
        credits.SetActive(false);
        mainMenu.SetActive(true);

        startGameButton.Select();
        PlaySelectSound();
    }

    public void PlaySelectSound()
    {
        SelectEffect.Play();
    }

    public void PlayButtonSound()
    {
        ButtonSoundEffect.Play();
    }

    public void PlayShakeAnimation()
    {
        
    }
}
