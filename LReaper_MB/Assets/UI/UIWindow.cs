using DG.Tweening;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class UIWindow : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private string windowID;
    [SerializeField] private Canvas windowCanvas;
    [SerializeField] private CanvasGroup windowCanvasGroup;

    [Header("Options")]
    [SerializeField] private bool hideOnStart = true;
    [SerializeField] private float animationTime = 0.5f;
    // Animation easing types from DOTween 
    [SerializeField] private Ease easeShow = Ease.InBack;
    [SerializeField] private Ease easeHide = Ease.OutBack;

    public UnityEvent OnStartShowingUI { get; private set; } = new UnityEvent();
    public UnityEvent OnFinishedShowingUI { get; private set; } = new UnityEvent();
    public UnityEvent OnStartHidingUI { get; private set; } = new UnityEvent();
    public UnityEvent OnFinishedHidingUI { get; private set; } = new UnityEvent();
    public bool IsShowing { get; private set; } = false;
    public string WindowID => windowID;
    void Start()
    {
        Initialize();
    }

    public virtual void Initialize()
    {
        if (hideOnStart) Hide(instant:true);
    }
    public virtual void Show(bool instant=false)
    {
        //windowsCanvas.gameObject.SetActive(true);
        if (instant)
        {
            windowCanvasGroup.transform.DOScale(Vector3.one, 0.5f);
        }
        else
        {
            windowCanvasGroup.transform.DOScale(Vector3.one, 0.5f);
        }
    }

    public virtual void Hide(bool instant = false)
    {
        //windowsCanvas.gameObject.SetActive(false);
        if (instant)
        {
            windowCanvasGroup.transform.DOScale(Vector3.zero, 0.5f);
        }
        else
        {
            windowCanvasGroup.transform.DOScale(Vector3.zero, 0.5f);
        }
    }
}
