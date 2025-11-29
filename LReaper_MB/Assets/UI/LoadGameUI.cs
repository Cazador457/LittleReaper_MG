using UnityEngine;
using UnityEngine.UI;


public class LoadGameUI : UIWindow
{
    [Header("Home Properties")]
    [SerializeField] private Button _load1;
    [SerializeField] private Button _load2;
    [SerializeField] private Button _load3;
    [SerializeField] private Button _load4;
    [SerializeField] private Button _exit;

    public override void Initialize()
    {
        base.Initialize();
        _load1.onClick.AddListener(Load1);
        _load2.onClick.AddListener(Load2);
        _load3.onClick.AddListener(Load3);
        _load4.onClick.AddListener(Load4);
        _exit.onClick.AddListener(Exit);
    }
    private void OnDestroy()
    {
        _load1.onClick.RemoveListener(Load1);
        _load2.onClick.RemoveListener(Load2);
        _load3.onClick.RemoveListener(Load3);
        _load4.onClick.RemoveListener(Load4);
        _load4.onClick.RemoveListener(Exit);
    }
    private void Load1()
    {
        ChangeSceneManager.Instance.ChangeScene(4);
        Hide();
        UIManager.Instance.ShowUI(WindowsIDs.Game);
        ChangeSceneManager.Instance.sceneIndex = 4;
    }
    private void Load2()
    {
        ChangeSceneManager.Instance.ChangeScene(2);
        Hide();
        UIManager.Instance.ShowUI(WindowsIDs.Game);
        ChangeSceneManager.Instance.sceneIndex = 2;
    }
    private void Load3()
    {
        ChangeSceneManager.Instance.ChangeScene(3);
        Hide();
        UIManager.Instance.ShowUI(WindowsIDs.Game);
        ChangeSceneManager.Instance.sceneIndex = 3;
    }
    private void Load4()
    {
        ChangeSceneManager.Instance.ChangeScene(5);
        Hide();
        UIManager.Instance.ShowUI(WindowsIDs.Game);
        ChangeSceneManager.Instance.sceneIndex = 5;
    }
    private void Exit()
    {
        Hide();
        UIManager.Instance.ShowUI(WindowsIDs.Game);
    }
}
