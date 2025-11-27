using UnityEngine;
using UnityEngine.UI;

public class StartUI : UIWindow
{
    [Header("Home Properties")]
    [SerializeField] private Image _player;
    [SerializeField] private Button _play;
    [SerializeField] private Button _sound;
    [SerializeField] private Button _credits;
    [SerializeField] private Button _exit;

    [Header("Resources")]
    public ChangeSceneManager SceneManager;

    public override void Initialize()
    {
        base.Initialize();
        _play.onClick.AddListener(Play);
        _sound.onClick.AddListener(Sound);
        _credits.onClick.AddListener(Credits);
        _exit.onClick.AddListener(Exit);
    }
    private void OnDestroy()
    {
        _play.onClick.RemoveListener(Play);
        _sound.onClick.RemoveListener(Sound);
        _credits.onClick.AddListener(Credits);
        _exit.onClick.RemoveListener(Exit);
    }
    private void Play()
    {
        Hide();
        ChangeSceneManager.Instance.ChangeScene(0);
        UIManager.Instance.ShowUI(WindowsIDs.Game);
    }
    private void Sound()
    {
        Hide();
        UIManager.Instance.ShowUI(WindowsIDs.Sound);
    }
    private void Credits()
    {
        Hide();
        UIManager.Instance.ShowUI(WindowsIDs.Credits);
    }
    private void Exit()
    {
        ChangeSceneManager.Instance.Exit();
    }
}
