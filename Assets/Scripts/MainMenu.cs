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
    public GameObject loadingScreen;
    [Header("Buttons")]
    public Button creditsBackButton;
    public Button optionsBackButton;
    public Button startGameButton;
    public Slider loadingBar;
    [Header("Sounds")]
    public AudioSource SelectEffect;
    public AudioSource ButtonSoundEffect;

    public Animator buttonShake;

    public void StartGame(int sceneIndex)
    {
        Scene currentScene = SceneManager.GetActiveScene();

        StartCoroutine(LoadLevelAsync(sceneIndex));
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

    IEnumerator LoadLevelAsync(int sceneIndex)
    {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(sceneIndex);

        mainMenu.SetActive(false);
        loadingScreen.SetActive(true);

        while (!loadOperation.isDone)
        {
            float progress = Mathf.Clamp01(loadOperation.progress / .9f);
            Debug.Log(progress);

            loadingBar.value = progress;

            yield return null;
        }
    }

}
