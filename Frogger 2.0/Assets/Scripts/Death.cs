using UnityEngine.SceneManagement;
using UnityEngine;

public class Death : MonoBehaviour {

    public Rigidbody2D player;

	void OnTriggerEnter2D (Collider2D collider)
    {
        if(collider.tag == "Death Object")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
