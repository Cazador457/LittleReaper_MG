using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed=5;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //_inputHorizontal = Input.GetAxisRaw("Horizontal");
    }
}
