using UnityEngine;

public class InventoryUI : UIWindow
{
    [SerializeField] private GameObject itemPrefab;
    [SerializeField] private GameObject content;

    private void SpawnItem()
    {
        GameObject go=Instantiate(itemPrefab,content.transform);
    }

}
