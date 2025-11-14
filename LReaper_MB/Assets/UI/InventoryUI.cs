using NaughtyAttributes;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : UIWindow
{
    [Header("Inventory UI")]
    [BoxGroup("Inventory")] [SerializeField] private GameObject itemPrefab;
    [BoxGroup("Inventory")] [SerializeField] private GameObject content;

    [Header("Game Properties")]
    [SerializeField] private Button _pause;
    [SerializeField] private Button _exit;

    public override void Initialize()
    {
        base.Initialize();
        _pause.onClick.AddListener(Pause);
        _exit.onClick.AddListener(Exit);
    }
    private void OnDestroy()
    {
        _pause.onClick.RemoveListener(Pause);
        _exit.onClick.RemoveListener(Exit);
    }

    private void Pause()
    {
        UIManager.Instance.ShowUI(WindowsIDs.Pause);
        Hide();
    }
    private void Exit()
    {
        UIManager.Instance.ShowUI(WindowsIDs.Game);
        Hide();
    }

    //
    public void CreateItems(List<ItemData> items)
    {
        foreach (var item in items)
        {
            SpawnItem(item);
        }

    }

    private void SpawnItem(ItemData itemData)
    {
        GameObject go = Instantiate(itemPrefab, content.transform);
        InventoryItem item = go.GetComponent<InventoryItem>();
        item.SetInfo(itemData.sprite, itemData.text);
    }

}
