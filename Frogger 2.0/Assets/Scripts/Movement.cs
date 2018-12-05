using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody2D player;
    private float maxSwipeTime = 2.0f;
    private float minSwipeDist = 0.002f; // Minimum Swipe Distance.

    float startSwipe;
    float endSwipe;
    float swipeDistance;
    float swipeTime;

    Vector3 swipeStartPos;  //Swipe End Position.
    Vector3 swipeEndPos;    //Swipe Start Position.

    /*
     * Swipe() detects the direction ove the swipe 
     *  and moves the player accordingly.
     */

    void swipe()
    {
        Vector2 distance = swipeEndPos - swipeStartPos;
        if (Mathf.Abs(distance.x) > Mathf.Abs(distance.y)) //Gets the absolute value of the swipe and compares x and y.
        {
            if (distance.x > 0)
            {
                player.MovePosition(player.position + Vector2.right);
            }
            else
            {
                player.MovePosition(player.position + Vector2.left);
            }
        }
        else if (Mathf.Abs(distance.y) > Mathf.Abs(distance.x))
        {
            if (distance.y > 0)
            {
                player.MovePosition(player.position + Vector2.up);
                Score.addPoints();
            }
            else
            {
                player.MovePosition(player.position + Vector2.down);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                startSwipe = Time.time;
                swipeStartPos = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {

                endSwipe = Time.time;
                swipeEndPos = touch.position;
                swipeDistance = (swipeEndPos - swipeStartPos).magnitude;
                swipeTime = endSwipe - startSwipe;

                if (swipeTime < maxSwipeTime && swipeDistance > minSwipeDist)
                {
                    swipe();
                }
            }
        }
    }
}