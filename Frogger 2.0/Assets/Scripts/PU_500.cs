using UnityEngine;

public class PU_500 : MonoBehaviour
{
    public Rigidbody2D powerUp;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Score.add500();
            Destroy(gameObject);
        }
    }
}