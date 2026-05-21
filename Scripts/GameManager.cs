using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject winText;
    public GameObject gameOverText;

    private int score = 0;
    private bool gameEnded = false;

    void Update()
    {
        if (gameEnded && Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }

    public void AddScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }

    public void WinGame()
    {
        gameEnded = true;
        winText.SetActive(true);
        Time.timeScale = 0f;
    }

    public void GameOver()
    {
        gameEnded = true;
        gameOverText.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}