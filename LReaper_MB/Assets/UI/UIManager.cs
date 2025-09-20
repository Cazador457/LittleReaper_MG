using System.Collections.Generic;
using Dino.UtilityTools.Singleton;
using NaughtyAttributes;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] private List<UIWindow> uiWindows = new List<UIWindow>();

    public void ShowUI(string windowUI)
    {
        foreach (var window in uiWindows)
        {
            if (window.WindowID == windowUI)
            {
                window.Show();
                return;
            }
        }
        Debug.LogWarning($"UI Window with name {windowUI} not found.");
    }
    public void HideUI(string windowUI)
    {
        foreach (var window in uiWindows)
        {
            if (window.WindowID == windowUI)
            {
                window.Hide();
                return;
            }
        }
        Debug.LogWarning($"UI Window with name {windowUI} not found.");
    }
    public void HideAllUI()
    {
        foreach (var window in uiWindows)
        {
            window.Hide();
        }
    }
    public UIWindow GetUIWindow(string windowUI)
    {
        foreach (var window in uiWindows)
        {
            if (window.WindowID == windowUI)
            {
                return window;
            }
        }
        Debug.LogWarning($"UI Window with name {windowUI} not found.");
        return null;
    }
}
