using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstPersonCamera : MonoBehaviour
{
    public Transform penguinBody;
    float xRotation = 0f;
    public float turnSpeed = 200f;
    public float turnSpeed2 = 500f;
    public Vector2 turn;
    public Vector3 deltaMove;

    void MouseRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * turnSpeed * Time.deltaTime;
        turn.x += Input.GetAxis("Mouse X") * turnSpeed * Time.deltaTime;
        turn.y = Input.GetAxis("Mouse Y") * turnSpeed * Time.deltaTime;

        xRotation -= turn.y;
        //overload방/
        xRotation = Mathf.Clamp(xRotation, -45f, 80f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0f);
        //penguinBody.localRotation = Quaternion.Euler(0, turn.x, 0f);
        penguinBody.Rotate(Vector3.up * mouseX);

    }
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        MouseRotation();
    }
}
