using UnityEngine;

public class Ball : MonoBehaviour
{
    public void OnMouseDown()
    {
        // เมื่อคลิกบอล
        Respawn();
        ScoreManager.Instance.AddScore(1); // เพิ่มคะแนน
    }

    private void Respawn()
    {
        // สุ่มตำแหน่งใหม่ในพื้นที่ที่กำหนด
        Vector2 randomPosition = new Vector2(Random.Range(-8f, 8f), Random.Range(-4f, 4f));
        transform.position = randomPosition;
    }
}
