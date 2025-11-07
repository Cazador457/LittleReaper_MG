using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 6f;

    private Rigidbody rb;
    private Vector2 input;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // Para evitar girar por físicas
    }

    private void Update()
    {
        // Leer input del jugador
        input = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        );

        DetectDirection();
    }

    private void FixedUpdate()
    {
        // Movimiento en 3D X y Z
        Vector3 moveDir = new Vector3(input.x, 0, input.y).normalized;

        rb.linearVelocity = moveDir * speed + new Vector3(0, rb.linearVelocity.y, 0);
    }

    // --- 8 DIRECCIONES ---

    private void DetectDirection()
    {
        if (input == Vector2.zero) return;

        if (input.x > 0 && input.y == 0) MoveRight();
        if (input.x < 0 && input.y == 0) MoveLeft();
        if (input.x == 0 && input.y > 0) MoveForward();
        if (input.x == 0 && input.y < 0) MoveBackward();

        if (input.x > 0 && input.y > 0) MoveForwardRight();
        if (input.x < 0 && input.y > 0) MoveForwardLeft();
        if (input.x > 0 && input.y < 0) MoveBackwardRight();
        if (input.x < 0 && input.y < 0) MoveBackwardLeft();
    }

    // --- MÉTODOS POR DIRECCIÓN ---

    private void MoveForward() { Debug.Log("Avanzando "); }
    private void MoveBackward() { Debug.Log("Retrocediendo "); }
    private void MoveLeft() { Debug.Log("Izquierda "); }
    private void MoveRight() { Debug.Log("Derecha "); }

    private void MoveForwardRight() { Debug.Log("Diagonal "); }
    private void MoveForwardLeft() { Debug.Log("Diagonal "); }
    private void MoveBackwardRight() { Debug.Log("Diagonal "); }
    private void MoveBackwardLeft() { Debug.Log("Diagonal "); }
}
