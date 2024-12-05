using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public TextMeshProUGUI scoreText; // UI สำหรับคะแนน
    public TextMeshProUGUI timerText; // UI สำหรับเวลา
    public GameObject endGamePanel; // Panel สำหรับหน้าสรุปผล
    public TextMeshProUGUI finalScoreText; // UI สำหรับแสดงคะแนนสุดท้าย

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void UpdateScore(int score)
    {
        // อัปเดตคะแนนใน UI
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    public void UpdateTimer(float time)
    {
        // อัปเดตเวลาใน UI
        if (timerText != null)
        {
            timerText.text = "Time: " + Mathf.CeilToInt(time).ToString();
        }
    }

    public void ShowEndGamePanel(int finalScore)
    {
        // แสดงหน้าสรุปผล
        if (endGamePanel != null)
        {
            endGamePanel.SetActive(true);
            finalScoreText.text = "Final Score: " + finalScore; // แสดงคะแนนสุดท้าย
        }
    }

    public void HideEndGamePanel()
    {
        // ซ่อนหน้าสรุปผล
        if (endGamePanel != null)
        {
            endGamePanel.SetActive(false);
        }
    }
}
