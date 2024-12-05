using UnityEngine;

public class StaticBall : MonoBehaviour
{
    public void OnMouseDown()
    {
        // เมื่อคลิกบอล
        Respawn();
        ScoreManager.Instance.AddScore(1); // เพิ่มคะแนน
    }

    private void Respawn()
    {
        // สุ่มตำแหน่งใหม่
        Vector2 randomPosition = new Vector2(Random.Range(-8f, 8f), Random.Range(-4f, 4f));
        transform.position = randomPosition;
    }
}
