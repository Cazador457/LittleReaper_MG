using UnityEngine;

public class CreateFlower : MonoBehaviour
{
    public RavenGameManager raven;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PLayer"))
        {
            RavenGameManager.Instance.CreateAllItems();
            gameObject.SetActive(false);
        }
    }
}
