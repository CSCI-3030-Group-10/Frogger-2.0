using UnityEngine;

public class WrapBottomEdge : MonoBehaviour
{
    public Rigidbody2D player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player.position = new Vector2(player.position.x, 4.5f);
        }
    }
}
