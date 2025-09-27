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

    [Header("Resources")]
    public ChangeSceneManager SceneManager;

    public override void Initialize()
    {
        base.Initialize();
        _play.onClick.AddListener(Play);
        _sound.onClick.AddListener(Sound);
        _exit.onClick.AddListener(Exit);
    }
    private void OnDestroy()
    {
        _play.onClick.RemoveListener(Play);
        _sound.onClick.RemoveListener(Sound);
        _exit.onClick.RemoveListener(Exit);
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
        ChangeSceneManager.Instance.MenuReturnScene();

    }

    
}
