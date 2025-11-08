using UnityEngine;

public class Hit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RavenGameManager.Instance.Res();
            Debug.Log("Die");
        }
    }
}
