﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class BackController : MonoBehaviour
{

    public void NextScene()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}