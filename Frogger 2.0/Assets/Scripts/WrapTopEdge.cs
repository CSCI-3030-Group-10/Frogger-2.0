using UnityEngine;

public class WrapTopEdge : MonoBehaviour
{
    public Rigidbody2D player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.position = new Vector2(player.position.x, -4.5f);
    }
}

