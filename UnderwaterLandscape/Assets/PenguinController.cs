using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinController : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 5f;
    public float gravity = -9.81f;
    public float jumpHeight = 7f;

    public Transform groundCheck;
    public float groundDistance = 4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

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
        myMove();
        //CharacterRotation();
    }

    void myMove()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        if (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
    //public void CharacterRotation()
    //{
    //    turn.x += Input.GetAxis("Mouse X") * turnSpeed * Time.deltaTime;
    //    turn.y = Input.GetAxis("Mouse Y") * turnSpeed * Time.deltaTime;

    //    //xRotation -= turn.y;
    //    //overload방/
    //    //xRotation = Mathf.Clamp(xRotation, -90f, 90f);
    //    transform.localRotation = Quaternion.Euler(0, turn.x, 0f);
    //}

}
