using UnityEngine;
using Dino.UtilityTools.Singleton;

public class PlayerController : Singleton<PlayerController>
{
    public Joystick joystick;
    public float speed = 5f;
    public Transform cameraTransform;   // <--- Referencia a la cámara
    public float rotationSpeed = 10f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Input del joystick
        Vector3 input = new Vector3(joystick.Horizontal, 0, joystick.Vertical);

        if (input.magnitude > 0.1f)
        {
            // Dirección de la cámara (solo plana)
            Vector3 camForward = cameraTransform.forward;
            Vector3 camRight = cameraTransform.right;

            camForward.y = 0;
            camRight.y = 0;

            camForward.Normalize();
            camRight.Normalize();

            // Dirección en base a la cámara
            Vector3 moveDir = camForward * input.z + camRight * input.x;

            // Mover al personaje
            rb.MovePosition(rb.position + moveDir * speed * Time.fixedDeltaTime);

            // Rotar al personaje hacia la dirección
            Quaternion targetRot = Quaternion.LookRotation(moveDir);
            rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRot, rotationSpeed * Time.fixedDeltaTime));
        }
    }

    public void Attack1()
    {

    }
    public void Attack2()
    {

    }
}
