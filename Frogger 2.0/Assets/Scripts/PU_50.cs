using UnityEngine;

public class PU_50 : MonoBehaviour {

    public Rigidbody2D powerUp;
    public float deleteTimer = 2f;
    public float counter = 0.05f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Score.add50();
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        deleteTimer -= counter;

        if(counter <= 0)
        {
            Destroy(gameObject);
            deleteTimer = 3f;
        }
    }
}