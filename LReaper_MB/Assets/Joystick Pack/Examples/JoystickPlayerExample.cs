using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;

    public void FixedUpdate()
    {
        /*Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);*/
        Move();
    }

    //adicionado mio
    public void Move()
    {
        Vector3 direction = new Vector3(variableJoystick.Horizontal, 0, variableJoystick.Vertical);
        rb.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);

    }
}