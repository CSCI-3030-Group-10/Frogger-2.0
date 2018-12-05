using UnityEngine.SceneManagement;
using UnityEngine;

public class Death : MonoBehaviour {

    public Rigidbody2D player;
    public static int lives = 3;
    Vector2 startPosition = new Vector2(-0.5f, 0.5f);


    void OnTriggerEnter2D (Collider2D collider)
    {
        if(collider.tag == "Death Object" )
        {
            if (lives <= 1)
            {
                SceneManager.LoadScene("GameOverScreen");
                lives = 3;
                LivesDisplay.livesUpdate(lives);
               
            }
            else
            {
                player.position = startPosition;
                lives--;
                LivesDisplay.livesUpdate(lives);
            }
        }
    }

    public static void addLife()
    {
        if (lives < 3)
        {
            lives++;
            LivesDisplay.livesUpdate(lives);
        }
    }
}
