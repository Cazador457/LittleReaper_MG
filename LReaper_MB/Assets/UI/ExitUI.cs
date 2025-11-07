using UnityEngine;
using UnityEngine.UI;

public class ExitUI : UIWindow
{
    [Header("Home Properties")]
    [SerializeField] private Button _exit;
    [SerializeField] private Button _return;

    [Header("Resources")]
    public ChangeSceneManager SceneManager;

    public override void Initialize()
    {
        base.Initialize();
        _return.onClick.AddListener(Return);
        _exit.onClick.AddListener(Exit);
    }
    private void OnDestroy()
    {
        _return.onClick.RemoveListener(Return);
        _exit.onClick.RemoveListener(Exit);
    }
    private void Return() => Hide();
    private void Exit() => ChangeSceneManager.Instance.Exit();
}
