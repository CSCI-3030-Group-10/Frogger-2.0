using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsController : MonoBehaviour {
    public void NextScene()
    {
        SceneManager.LoadScene("SettingsScreen");
    }
}