using System.Collections.Generic;
using Dino.UtilityTools.Singleton;
using NaughtyAttributes;
using UnityEngine;
using System.Collections;

public class RavenGameManager : Singleton<RavenGameManager>
{
    public GameObject respawnPosition;
    private Transform targetT;
    public GameObject player;
    public float enemiesKilled = 0;

    [SerializeField] private UIManager uiManager;
    [SerializeField] private List<ItemData> items;
    public UIManager UIManager => uiManager;

    public List<ItemData> Items => items;

    [Button]
    public void CreateAllItems()
    {
        InventoryUI inventoryUI = UIManager.Instance.GetUIWindow(WindowsIDs.Inventory) as InventoryUI;
        if (inventoryUI == null) return;
        inventoryUI.CreateItems(items);
    }
    //
    IEnumerator Respawn()
    {
        player.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        player.transform.position = respawnPosition.transform.position;
        player.SetActive(true);
    }
    public void Res()
    {
        StartCoroutine(Respawn());
    }

    void Start()
    {
        Application.targetFrameRate = 60;
        respawnPosition = GameObject.Find("Respawn");
        targetT = respawnPosition.GetComponent<Transform>();
    }

    void Update()
    {
        
    }
}
