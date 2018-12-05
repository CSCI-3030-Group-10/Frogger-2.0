using UnityEngine;
using UnityEngine.SceneManagement;

public class HSController : MonoBehaviour
{

    public void NextScene()
    {
        SceneManager.LoadScene("HighScoresScene");
    }
}