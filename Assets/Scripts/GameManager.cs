using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public Button restartButton;
    public TextMeshProUGUI scoreText;  // Para el score opcional

    private float score = 0f;

    private void Start()
    {
        Time.timeScale = 1f;
        gameOverText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        if (scoreText != null)
        {
            scoreText.text = "SCORE: 0";
        }
    }

    private void Update()
    {
        if (Time.timeScale == 1f && scoreText != null)  // Solo cuenta si el juego está activo
        {
            score += Time.deltaTime * 10f;
            scoreText.text = $"SCORE: {Mathf.FloorToInt(score)}";
        }
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

