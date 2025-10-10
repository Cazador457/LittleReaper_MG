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

    private void Start()
    {
        Initialize();
    }
    //This is the way with Lambda Expression
    //The Lambda Expression is useful when only 1 method is called, with 2/more it is not used
    //void Start() => Initialize();

    public virtual void Initialize()
    {
        if (hideOnStart) Hide(instant:true);
    }
    public virtual void Show(bool instant=false)
    {
        if (IsShowing) return;
        windowCanvas.gameObject.SetActive(true);
        if (instant)
        {
            windowCanvasGroup.transform.DOScale(Vector3.one, 0f);
        }
        else
        {
            windowCanvasGroup.transform.DOScale(Vector3.one, animationTime).SetEase(easeShow);
            IsShowing = true;
            
        }
    }

    public virtual void Hide(bool instant = false)
    {
        windowCanvas.gameObject.SetActive(false);
        if (instant)
        {
            windowCanvasGroup.transform.DOScale(Vector3.zero, 0f);
        }
        else
        {
            //This is the way with Lambda Expression
            windowCanvasGroup.transform.DOScale(Vector3.zero, animationTime).SetEase(easeHide).OnComplete(()=> 
            {
                windowCanvas.gameObject.SetActive(false);
                IsShowing = false;
            });
            //This is the methodical way
            //windowCanvasGroup.transform.DOScale(Vector3.zero, animationTime).SetEase(easeHide).OnComplete(DisableCanvas);
        }
    }
    /*private void DisableCanvas()
    {
        windowCanvas.gameObject.SetActive(false);
        IsShowing = false;
    }*/
}
