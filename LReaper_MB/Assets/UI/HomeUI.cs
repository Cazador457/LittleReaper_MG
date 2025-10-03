using UnityEngine;
using UnityEngine.InputSystem;
using System;
using UnityEngine.UI;
using TMPro;

public class HomeUI : UIWindow
{
    [Header("Home Properties")]
    [SerializeField] private Button _play;
    [SerializeField] private Button _sound;
    [SerializeField] private Button _exit;

    [Header("Resources")]
    public ChangeSceneManager SceneManager;

    public override void Initialize()
    {
        base.Initialize();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
