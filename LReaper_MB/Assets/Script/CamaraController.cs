using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public Transform target;       // El jugador
    public float distance = 5f;    // Distancia de la cámara
    public float sensitivity = 0.2f;
    public float minY = -30f;
    public float maxY = 50f;

    private float rotX;
    private float rotY;

    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        rotX = angles.y;
        rotY = angles.x;
    }

    void LateUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);

            if (t.phase == TouchPhase.Moved)
            {
                rotX += t.deltaPosition.x * sensitivity;
                rotY -= t.deltaPosition.y * sensitivity;
                rotY = Mathf.Clamp(rotY, minY, maxY);
            }
        }

        Quaternion rotation = Quaternion.Euler(rotY, rotX, 0);

        Vector3 negDistance = new Vector3(0, 0, -distance);
        Vector3 position = rotation * negDistance + target.position;

        transform.rotation = rotation;
        transform.position = position;
    }
}
