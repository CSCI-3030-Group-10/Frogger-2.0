using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    static Text lives;

    private void Start()
    {
        lives = GetComponent<Text>();
    }

    public static void livesUpdate (float value)
    {
        if(value == 3)
        {
            lives.text = "Lives:\n\t 3";
        }
        else if(value == 2)
        {
            lives.text = "Lives:\n\t 2";
        }
        else if(value == 1)
        {
            lives.text = "Lives:\n\t 1";
        }
    }
}
