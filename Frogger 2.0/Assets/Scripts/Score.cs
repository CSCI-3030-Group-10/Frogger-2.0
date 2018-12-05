using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    //public Transform player;
    //public Text scoreText;
    public static float gameScore = 0;
    public static  float previousscore = 0;
    static Text score;

    private void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    public static void addPoints () {
        gameScore = previousscore + 10f;
        previousscore = gameScore;
        score.text = gameScore.ToString();
	}

    //Resets the score to 0.
    public static void reset()
    {
        gameScore = 0f;
        previousscore = 0f;
        score.text = gameScore.ToString();
    }

    //Adds 50 to score.
    public static void add50()
    {
        gameScore = previousscore + 50f;
        previousscore = gameScore;
        score.text = gameScore.ToString();
    }

    //Adds 100 to score.
    public static void add100()
    {
        gameScore = previousscore + 100f;
        previousscore = gameScore;
        score.text = gameScore.ToString();
    }

    //Adds 150 to score.
    public static void add150()
    {
        gameScore = previousscore + 150f;
        previousscore = gameScore;
        score.text = gameScore.ToString();
    }

    //Adds 500 to score.
    public static void add500()
    {
        gameScore = previousscore + 500f;
        previousscore = gameScore;
        score.text = gameScore.ToString();
    }

}
