using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstPersonCamera : MonoBehaviour
{
    //public Transform penguinBody;
    float xRotation = 0f;
    public float turnSpeed = 100f;
    public Vector2 turn;
    public Vector3 deltaMove;

    void MouseRotation()
    {
        turn.x += Input.GetAxis("Mouse X") * turnSpeed * Time.deltaTime;
        turn.y = Input.GetAxis("Mouse Y") * turnSpeed * Time.deltaTime;

        xRotation -= turn.y;
        //overload방/
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, turn.x, 0f);

        //penguinBody.Rotate(Vector3.up * mouseX);

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
