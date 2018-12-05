using UnityEngine;

public class PU_150 : MonoBehaviour
{
    public Rigidbody2D powerUp;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Score.add150();
            Destroy(gameObject);
        }
    }
}