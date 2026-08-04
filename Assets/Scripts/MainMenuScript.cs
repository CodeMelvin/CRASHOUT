using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuScript : MonoBehaviour
{
    public GameObject mainScreen;
    public GameObject settingsScreen;
    public GameObject creditsScreen;
    public GameObject loadingScreen;

    public void Play()
    {
        mainScreen.SetActive(false);
        loadingScreen.SetActive(true);

        StartCoroutine(LoadSceneAsync());
    }

    IEnumerator LoadSceneAsync()
    {
        AsyncOperation op = SceneManager.LoadSceneAsync("Map");
        op.allowSceneActivation = false;

        yield return new WaitForSeconds(1f);

        while (!op.isDone)
        {
            if (op.progress >= 0.9f)
            {
                op.allowSceneActivation = true;
            }

            yield return null;
        }
    }

    public void Settings()
    {
        mainScreen.SetActive(false);
        settingsScreen.SetActive(true);
    }

    public void Credits()
    {
        mainScreen.SetActive(false);
        creditsScreen.SetActive(true);
    }

    public void BackToMainMenu()
    {
        settingsScreen.SetActive(false);
        creditsScreen.SetActive(false);
        mainScreen.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}