using UnityEngine;
using DG.Tweening;

public class UIWindow : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private string windowsID;
    [SerializeField] private Canvas windowsCanvas;
    [SerializeField] private CanvasGroup windowsCanvasGroup;

    [Header("Options")]
    [SerializeField] private bool hideOnStart = true;
    
    public string WindowID => windowsID;
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
            windowsCanvasGroup.transform.DOScale(Vector3.one, 0.5f);

        }
        else
        {
            windowsCanvasGroup.transform.DOScale(Vector3.one, 0.5f);
        }
    }

    public virtual void Hide(bool instant = false)
    {
        //windowsCanvas.gameObject.SetActive(false);
        if (instant)
        {
            windowsCanvasGroup.transform.DOScale(Vector3.zero, 0.5f);

        }
        else
        {
            windowsCanvasGroup.transform.DOScale(Vector3.zero, 0.5f);
        }
    }

    void Update()
    {
        
    }
}
