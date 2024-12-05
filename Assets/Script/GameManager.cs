using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float timer = 30f; // ตั้งเวลา
    private bool isGameRunning = true; // ตรวจสอบสถานะเกม

    void Start()
    {
        UIManager.Instance.HideEndGamePanel(); // ซ่อนหน้าสรุปผลเมื่อเริ่มเกม
    }

    void Update()
    {
        if (isGameRunning)
        {
            // ลดเวลา
            timer -= Time.deltaTime;
            UIManager.Instance.UpdateTimer(timer); // อัปเดตเวลาใน UI

            if (timer <= 0)
            {
                EndGame(); // เรียกใช้ฟังก์ชันเมื่อเวลาหมด
            }
        }
    }

    private void EndGame()
    {
        isGameRunning = false; // หยุดเกม
        UIManager.Instance.ShowEndGamePanel(ScoreManager.Instance.GetScore()); // แสดงหน้าสรุปผล
    }

    public void RestartGame()
    {
        // รีเซ็ตเกม
        isGameRunning = true;
        timer = 30f;
        ScoreManager.Instance.ResetScore();
        UIManager.Instance.HideEndGamePanel(); // ซ่อนหน้าสรุปผล
    }
}
