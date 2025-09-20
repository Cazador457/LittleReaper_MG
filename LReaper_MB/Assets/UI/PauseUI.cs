using UnityEngine;
using UnityEngine.InputSystem;
using System;
using UnityEngine.UI;
using TMPro;

public class PauseUI : UIWindow
{
    [Header("Pause Properties")]
    [SerializeField] private Image _player;
    [SerializeField] private Button _play;
    [SerializeField] private Button _sound;
    [SerializeField] private Button _exit;

    public override void Initialize()
    {
        base.Initialize();
    }
    private void Play()
    {
        Hide();
    }
    private void Sound()
    {
        Hide();
        UIManager.Instance.ShowUI("SoundUI");
    }
    private void Exit()
    {
        Hide();

    }

    
}
