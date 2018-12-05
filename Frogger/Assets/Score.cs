using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    //public Transform player;
    //public Text scoreText;
    public float gameScore = 0;
    public float previousscore = 0;
    public Text sscore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0)
        {
            gameScore = previousscore + 10;
            previousscore = gameScore;
            Debug.Log(gameScore);
            Debug.Log(previousscore);
            sscore.text = gameScore.ToString();
        }
        else 
        { 
            gameScore = previousscore;
        }  
	}
}
