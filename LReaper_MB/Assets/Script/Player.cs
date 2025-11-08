using UnityEngine;
using Dino.UtilityTools.Singleton;

public class Player : Singleton<Player>
{
    public float speed = 6f;

    private Rigidbody rb;
    private Vector2 input;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {
        input = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        );
        MoveR();
        DetectDirection();
    }

    private void FixedUpdate()
    {
        Vector3 moveDir = new Vector3(input.x, 0, input.y).normalized;

        rb.linearVelocity = moveDir * speed + new Vector3(0, rb.linearVelocity.y, 0);
    }

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
    public void MoveR()
    {
        if (input == Vector2.zero) return;
        if (input.x > 0 && input.y == 0) ;
    }
    public void MoveForward() { Debug.Log("Avanzando "); }
    public void MoveBackward() { Debug.Log("Retrocediendo "); }
    public void MoveLeft() { Debug.Log("Izquierda "); }
    public void MoveRight() { Debug.Log("Derecha "); }

    public void MoveForwardRight() { Debug.Log("Diagonal "); }
    public void MoveForwardLeft() { Debug.Log("Diagonal "); }
    public void MoveBackwardRight() { Debug.Log("Diagonal "); }
    public void MoveBackwardLeft() { Debug.Log("Diagonal "); }

    public void Attack()
    {

    }
    public void SpecialA()
    {

    }
    public void SpecialB()
    {

    }
}
