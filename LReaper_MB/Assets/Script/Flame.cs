using UnityEngine;

public class Flame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            flame();
        }
    }
    public void flame()
    {
        UIManager.Instance.ShowUI(WindowsIDs.LoadGame);
    }
}
