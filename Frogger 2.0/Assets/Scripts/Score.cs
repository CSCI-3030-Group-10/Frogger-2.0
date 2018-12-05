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

    public static void reset()
    {
        gameScore = 0f;
        previousscore = 0f;
        score.text = gameScore.ToString();
    }
}
