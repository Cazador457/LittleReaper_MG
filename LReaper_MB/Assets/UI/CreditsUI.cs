using UnityEngine;
using UnityEngine.InputSystem;
using System;
using UnityEngine.UI;
using TMPro;

public class CreditsUI : UIWindow
{
    [Header("Game Properties")]
    [SerializeField] private Button _return;

    public override void Initialize()
    {
        base.Initialize();
    }
}
