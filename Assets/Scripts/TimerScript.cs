using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text timerText;
    public float remainingTime;

    private bool gameOver = false;
    public GameObject gameUI;
    public GameObject gameOverScreen;

    public Text score;
    public Text finalScore;

    public GameObject mockHMD;

    public static bool timePaused = false;

    void Start()
    {
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void Update()
    {
        if (timePaused) return;

        if (gameOver) return;

        if (remainingTime > 11)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime > 1)
        {
            remainingTime -= Time.deltaTime;
            timerText.color = Color.red;
        }
        else if (remainingTime <= 1)
        {
            remainingTime = 0;
            timerText.color = Color.red;

            GameOver();
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void GameOver()
    {
        gameOver = true;

        gameUI.SetActive(false);

        finalScore.text = score.text;
        gameOverScreen.SetActive(true);

        mockHMD.SetActive(false);
    }
}