using UnityEngine;

public class MovingBall : MonoBehaviour
{
    public float speed = 2f; // ความเร็วของบอล
    private Vector2 direction;

    private void Start()
    {
        // สุ่มทิศทางการเคลื่อนที่
        direction = Random.insideUnitCircle.normalized;
    }

    private void Update()
    {
        // เคลื่อนที่
        transform.Translate(direction * speed * Time.deltaTime);

        // ตรวจสอบขอบเขต ถ้าหลุดออกจากพื้นที่ให้กลับทิศ
        if (transform.position.x > 8f || transform.position.x < -8f)
            direction.x *= -1;
        if (transform.position.y > 4f || transform.position.y < -4f)
            direction.y *= -1;
    }

    public void OnMouseDown()
    {
        // เมื่อคลิกบอล
        Respawn();
        ScoreManager.Instance.AddScore(2); // คะแนนเพิ่ม 2
    }

    private void Respawn()
    {
        // สุ่มตำแหน่งใหม่
        Vector2 randomPosition = new Vector2(Random.Range(-8f, 8f), Random.Range(-4f, 4f));
        transform.position = randomPosition;
    }
}
