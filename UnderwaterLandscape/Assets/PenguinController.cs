using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinController : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;

    float xRotation = 0f;
    public float turnSpeed = 100f;
    public Vector2 turn;
    public Vector3 deltaMove;

    // Start is called before the first frame update

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        CharacterRotation();
    }

    public void CharacterRotation()
    {
        turn.x += Input.GetAxis("Mouse X") * turnSpeed * Time.deltaTime;
        turn.y = Input.GetAxis("Mouse Y") * turnSpeed * Time.deltaTime;

        //xRotation -= turn.y;
        //overload방/
        //xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(0, turn.x, 0f);
    }

}
