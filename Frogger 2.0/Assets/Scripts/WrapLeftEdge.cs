using UnityEngine;

public class WrapLeftEdge : MonoBehaviour {

    public Rigidbody2D player;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.position = new Vector2(2.5f, player.position.y);
    }
}
