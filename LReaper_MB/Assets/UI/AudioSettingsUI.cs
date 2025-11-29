using UnityEngine;
using UnityEngine.UI;

public class AudioSettingsUI : UIWindow
{
    [Header("AudioSettings Properties")]
    [SerializeField] private Button _exit;
    [SerializeField] private Button _Ambiente;
    [SerializeField] private Button _enemyes;


    public override void Initialize()
    {
        base.Initialize();
        _exit.onClick.AddListener(Exit);
    }
    private void OnDestroy()
    {
        _exit.onClick.RemoveListener(Exit);
    }
    private void Exit()
    {
        if (ChangeSceneManager.Instance.sceneIndex == 0)
        {
            Hide();
            UIManager.Instance.ShowUI(WindowsIDs.Start);
        }
        if(ChangeSceneManager.Instance.sceneIndex >= 1)
        {
            Hide();
            UIManager.Instance.ShowUI(WindowsIDs.Game);
        }
    }
}
