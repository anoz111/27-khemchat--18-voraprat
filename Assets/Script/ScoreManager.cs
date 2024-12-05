using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    private int score = 0;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void AddScore(int value)
    {
        score += value; // เพิ่มคะแนน
        UIManager.Instance.UpdateScore(score); // อัปเดตคะแนนใน UI
    }

    public int GetScore()
    {
        return score;
    }

    public void ResetScore()
    {
        score = 0; // รีเซ็ตคะแนน
        UIManager.Instance.UpdateScore(score); // รีเซ็ตคะแนนใน UI
    }
}
