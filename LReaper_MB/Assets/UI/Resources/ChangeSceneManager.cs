using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneManager
{
    public int nScene;
    public float delay = 2f;

    public static void NextScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(nScene);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
