using System;
using System.Collections.Generic;
using Dino.UtilityTools.Singleton;
using NaughtyAttributes;
using UnityEngine;

public class RavenGameManager : Singleton<RavenGameManager>
{
    [SerializeField] private UIManager uiManager;
    [SerializeField] private List<ItemData> items;
    public UIManager UIManager => uiManager;

    public List<ItemData> Items => items;

    [Button]
    private void CreateAllItems()
    {
        InventoryUI inventoryUI = UIManager.Instance.GetUIWindow(WindowsUI.Inventory) as InventoryUI;
        if (inventoryUI == null) return;
        inventoryUI.CreateItems(items);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
