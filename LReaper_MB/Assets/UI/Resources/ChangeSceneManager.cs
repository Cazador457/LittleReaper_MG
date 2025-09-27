using UnityEngine;
using UnityEngine.SceneManagement;
using Dino.UtilityTools.Singleton;

public class ChangeSceneManager: Singleton<ChangeSceneManager>
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
    public void MenuReturnScene(int IndexScene=0)
    {
        SceneManager.LoadScene(IndexScene);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
