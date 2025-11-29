using UnityEngine;
using UnityEngine.SceneManagement;
using Dino.UtilityTools.Singleton;

public class ChangeSceneManager: Singleton<ChangeSceneManager>
{
    public int sceneIndex=0;

    public void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    public static void NextScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }
    public void UIout()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    public void ChangeScene(int IndexScene = 0)
    {
        SceneManager.LoadScene(IndexScene);
    }
    public void Exit()
    {
        Debug.Log("Clouse Game");
        Application.Quit();
    }
}
