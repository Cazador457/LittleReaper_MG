using UnityEngine;
using UnityEngine.UI;


public class LoadGameUI : UIWindow
{
    [Header("Home Properties")]
    [SerializeField] private Button _load1;
    [SerializeField] private Button _load2;
    [SerializeField] private Button _load3;
    [SerializeField] private Button _load4;

    public override void Initialize()
    {
        base.Initialize();
        _load1.onClick.AddListener(Load1);
        _load2.onClick.AddListener(Load2);
        _load3.onClick.AddListener(Load3);
        _load4.onClick.AddListener(Load4);
    }
    private void OnDestroy()
    {
        _load1.onClick.RemoveListener(Load1);
        _load2.onClick.RemoveListener(Load2);
        _load3.onClick.RemoveListener(Load3);
        _load4.onClick.RemoveListener(Load4);
    }
    private void Load1()
    {
        ChangeSceneManager.Instance.ChangeScene(2);
        Hide();
    }
    private void Load2()
    {
        ChangeSceneManager.Instance.ChangeScene(2);
        Hide();
    }
    private void Load3()
    {
        ChangeSceneManager.Instance.ChangeScene(2);
        Hide();
    }
    private void Load4()
    {
        ChangeSceneManager.Instance.ChangeScene(2);
        Hide();
    }
}
