using UnityEngine;
using UnityEngine.UI;

public class CreditsUI : UIWindow
{
    [Header("Game Properties")]
    [SerializeField] private Button _exit;

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
        else if (ChangeSceneManager.Instance.sceneIndex >= 1)
        {
            Hide();
            UIManager.Instance.ShowUI(WindowsIDs.Game);
        }
    }

}
