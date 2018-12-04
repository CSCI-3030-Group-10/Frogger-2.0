using UnityEngine;

public class Vehicle : MonoBehaviour {

    public Rigidbody2D car;

    /*
     * Setting the min and max speed.
     * Defaults are min = 1 and max = 2.
     */
    public float min = 1f;
    public float max = 2f;

    float speed;
    
    // Use this for initialization
    void Start () {
        speed = Random.Range(min, max);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector2 moveForward = new Vector2(transform.right.x, transform.right.y); //Needs to be inside update.
        car.MovePosition(car.position + moveForward * speed * Time.fixedDeltaTime);
	}
}
