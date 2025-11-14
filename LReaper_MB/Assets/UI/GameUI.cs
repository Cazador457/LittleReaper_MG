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
    [SerializeField] private Button _a;
    [SerializeField] private Button _d;
    [SerializeField] private Button _w;
    [SerializeField] private Button _s;
    [SerializeField] private Button _i;
    [SerializeField] private Button _j;
    [SerializeField] private Button _k;
    [SerializeField] private Button _l;

    public Player player;

    public override void Initialize()
    {
        base.Initialize();
        _pause.onClick.AddListener(Pause);
        _inventory.onClick.AddListener(Inventory);
        _attack.onClick.AddListener(Attack);
        _specialA.onClick.AddListener(SpecialA);
        _specialB.onClick.AddListener(SpecialB);
        _a.onClick.AddListener(A);
        _d.onClick.AddListener(D);
        _w.onClick.AddListener(W);
        _s.onClick.AddListener(S);
        _i.onClick.AddListener(I);
        _j.onClick.AddListener(J);
        _k.onClick.AddListener(K);
        _l.onClick.AddListener(L);
    }
    private void OnDestroy()
    {
        _pause.onClick.RemoveListener(Pause);
        _inventory.onClick.RemoveListener(Inventory);
        _attack.onClick.RemoveListener(Attack);
        _specialA.onClick.RemoveListener(SpecialA);
        _specialB.onClick.RemoveListener(SpecialB);
        _a.onClick.RemoveListener(A);
        _d.onClick.RemoveListener(D);
        _w.onClick.RemoveListener(W);
        _s.onClick.RemoveListener(S);
        _i.onClick.RemoveListener(I);
        _j.onClick.RemoveListener(J);
        _k.onClick.RemoveListener(K);
        _l.onClick.RemoveListener(L);
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
    private void W() => Player.Instance.MoveForward();
    private void S() => Player.Instance.MoveBackward();
    private void A() => Player.Instance.MoveLeft();
    private void D() => Player.Instance.MoveRight();
    private void I() => Player.Instance.MoveForwardRight();
    private void J() => Player.Instance.MoveForwardLeft();
    private void K() => Player.Instance.MoveBackwardLeft();
    private void L() => Player.Instance.MoveBackwardRight();
}
