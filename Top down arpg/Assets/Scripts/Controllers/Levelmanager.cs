using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class Levelmanager : MonoBehaviour{

    public void LoadLevel(string loadLevel)
    {
        SceneManager.LoadScene(loadLevel);
    }

    public void ReloadLevel()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
