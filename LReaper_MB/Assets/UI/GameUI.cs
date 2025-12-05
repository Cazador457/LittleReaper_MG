using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameUI : UIWindow
{
    [Header("Game Properties")]
    [SerializeField] private Button _pause;
    [SerializeField] private Button _inventory;
    [SerializeField] private Button _attack;
    [SerializeField] private Button _specialA;
    [SerializeField] private Button _specialB;

    public Player player;

    public override void Initialize()
    {
        base.Initialize();
        _pause.onClick.AddListener(Pause);
        _inventory.onClick.AddListener(Inventory);
        _attack.onClick.AddListener(Attack);
        _specialA.onClick.AddListener(SpecialA);
        _specialB.onClick.AddListener(SpecialB);
    }
    private void OnDestroy()
    {
        _pause.onClick.RemoveListener(Pause);
        _inventory.onClick.RemoveListener(Inventory);
        _attack.onClick.RemoveListener(Attack);
        _specialA.onClick.RemoveListener(SpecialA);
        _specialB.onClick.RemoveListener(SpecialB);
    }

    private void Pause()
    {
        UIManager.Instance.ShowUI(WindowsIDs.Pause);
        Hide();
    }
    private void Inventory()
    {
        UIManager.Instance.ShowUI(WindowsIDs.Inventory);
        Hide();
    }
    private void Attack() => Player.Instance.Attack();
    private void SpecialA() => Player.Instance.SpecialA();
    private void SpecialB() => Player.Instance.SpecialB();
}
