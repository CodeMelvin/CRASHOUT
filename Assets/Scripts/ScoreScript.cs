using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    private float currentScore;
    public float objectScore;

    void Update()
    {
        currentScore = float.Parse(scoreText.text);
    }

    public void updateScore()
    {
        currentScore += objectScore;
        scoreText.text = currentScore.ToString();
    }
}