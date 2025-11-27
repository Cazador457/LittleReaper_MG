using UnityEngine;
using Dino.UtilityTools.Singleton;

public class PlayerController : Singleton<PlayerController>
{
    [Header("Movement")]
    public float speed = 5f;
    public float rotationSmoothTime = 0.1f;
    private float rotationVelocity;

    [Header("References")]
    public Transform cameraTransform;

    private Vector3 inputDir;
    private Vector3 moveDir;

    private bool rotatedOnDown = false;

    void Update()
    {
        inputDir = Vector3.zero;

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A)) MoveUpLeft();
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D)) MoveUpRight();
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A)) MoveDownLeft();
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D)) MoveDownRight();

        else if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                Rotate180();
                rotatedOnDown = true;
            }
            MoveDown();
        }

        else
        {
            rotatedOnDown = false;

            if (Input.GetKey(KeyCode.W)) MoveUp();
            if (Input.GetKey(KeyCode.A)) MoveLeft();
            if (Input.GetKey(KeyCode.D)) MoveRight();
        }

        if (inputDir.magnitude >= 0.1f)
        {
            float targetAngle =
                Mathf.Atan2(inputDir.x, inputDir.z) * Mathf.Rad2Deg +
                cameraTransform.eulerAngles.y;

            float smoothAngle = Mathf.SmoothDampAngle(
                transform.eulerAngles.y,
                targetAngle,
                ref rotationVelocity,
                rotationSmoothTime
            );

            transform.rotation = Quaternion.Euler(0f, smoothAngle, 0f);

            moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
        }
        else moveDir = Vector3.zero;

        transform.position += moveDir.normalized * speed * Time.deltaTime;
    }

    void MoveUp() => inputDir += Vector3.forward;
    void MoveDown() => inputDir += Vector3.back;
    void MoveLeft() => inputDir += Vector3.left;
    void MoveRight() => inputDir += Vector3.right;

    void MoveUpLeft() => inputDir += (Vector3.forward + Vector3.left);
    void MoveUpRight() => inputDir += (Vector3.forward + Vector3.right);
    void MoveDownLeft() => inputDir += (Vector3.back + Vector3.left);
    void MoveDownRight() => inputDir += (Vector3.back + Vector3.right);

    void Rotate180()
    {
        float targetAngle = cameraTransform.eulerAngles.y + 180f;

        float smoothAngle = Mathf.SmoothDampAngle(
            transform.eulerAngles.y,
            targetAngle,
            ref rotationVelocity,
            rotationSmoothTime
        );

        transform.rotation = Quaternion.Euler(0f, smoothAngle, 0f);
    }

    public void attack1()
    {

    }
    public void attack2()
    {

    }
}
