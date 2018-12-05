using UnityEngine.SceneManagement;
using UnityEngine;


public class Death : MonoBehaviour {

    public Rigidbody2D player;
    public int lives = 3;
    Vector2 startPosition = new Vector2(0f, -4.5f);

	void OnTriggerEnter2D (Collider2D collider)
    {
        if(collider.tag == "Death Object" )
        {
            if (lives <= 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                lives = 3;
            }
            else
            {
                player.position = startPosition;
                lives--;
            }
        }
    }
}
