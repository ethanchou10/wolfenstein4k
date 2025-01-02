using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    public AudioSource clickSound;
    public GameObject fadeOut;

    public void NewGame()
    {
        StartCoroutine(NewGameRoutine());
    }

    IEnumerator NewGameRoutine()
    {
        clickSound.Play();
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResetGame()
    {
        PlayerPrefs.SetInt("SceneToLoad", 0);
        PlayerPrefs.SetInt("LivesSaved", 0);
        PlayerPrefs.SetInt("ScoreSaved", 0);
        PlayerPrefs.SetInt("AmmoSaved", 0);
        SceneManager.LoadScene(0);
    }
}
