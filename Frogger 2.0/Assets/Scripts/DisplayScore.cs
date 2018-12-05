using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {

    static Text finalScore;

    private void Start()
    {
        finalScore = GetComponent<Text>();
    }

    public static void scoreDisplay(float fScore)
    {
        finalScore.text = fScore.ToString();

    }
}
