using UnityEngine;
using UnityEngine.UI;

public class PauseUI : UIWindow
{
    [Header("Pause Properties")]
    [SerializeField] private Image _player;
    [SerializeField] private Button _play;
    [SerializeField] private Button _sound;
    [SerializeField] private Button _exit;

    [Header("Resources")]
    public ChangeSceneManager SceneManager;

    public override void Initialize()
    {
        base.Initialize();
        _play.onClick.AddListener(Play);
        _sound.onClick.AddListener(Sound);
        _exit.onClick.AddListener(Exit);
    }
    private void OnDestroy()
    {
        _play.onClick.RemoveListener(Play);
        _sound.onClick.RemoveListener(Sound);
        _exit.onClick.RemoveListener(Exit);
    }
    private void Play()
    {
        UIManager.Instance.ShowUI(WindowsIDs.Game);
        Hide();
    }
    private void Sound()
    {
        UIManager.Instance.ShowUI(WindowsIDs.Sound);
        Hide();

    }
    private void Exit()
    {
        if (ChangeSceneManager.Instance.sceneIndex == 1)
        {
            Hide();
            UIManager.Instance.ShowUI(WindowsIDs.Start);
            Debug.Log("Escena Home");
            ChangeSceneManager.Instance.ChangeScene(0);
            ChangeSceneManager.Instance.sceneIndex = 0;
        }
        if(ChangeSceneManager.Instance.sceneIndex >= 2)
        {
            Hide();
            UIManager.Instance.ShowUI(WindowsIDs.Game);
            Debug.Log("Escena Home");
            ChangeSceneManager.Instance.ChangeScene(1);
            ChangeSceneManager.Instance.sceneIndex = 1;
        }
    }
}
