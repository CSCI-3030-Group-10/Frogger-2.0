using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayController : MonoBehaviour
{

    public void NextScene()
    {
        SceneManager.LoadScene("Game Scene");
    }
}
