using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIScript : MonoBehaviour
{
    public GameObject gameUI;
    public GameObject pauseScreen;
    public GameObject settingsScreen;
    public GameObject mockHMD;

    private bool isPaused = false;

    public void Pause()
    {
        if (isPaused) return;

        isPaused = true;

        Time.timeScale = 0f;

        TimerScript.timePaused = true;

        pauseScreen.SetActive(true);
        mockHMD.SetActive(false);
    }

    public void Resume()
    {
        if (!isPaused) return;

        isPaused = false;

        Time.timeScale = 1f;

        TimerScript.timePaused = false;

        pauseScreen.SetActive(false);
        mockHMD.SetActive(true);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        TimerScript.timePaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        TimerScript.timePaused = false;
        SceneManager.LoadScene("MainMenu");
    }

    public void Settings()
    {
        pauseScreen.SetActive(false);
        gameUI.SetActive(false);
        settingsScreen.SetActive(true);
    }

    public void BackToPause()
    {
        settingsScreen.SetActive(false);
        pauseScreen.SetActive(true);
        gameUI.SetActive(true);
    }
}