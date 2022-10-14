using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotPlayer : MonoBehaviour
{
    public CharacterController characterController;
    public float speed;
    public float gravity = -9.81f;
    public Vector3 Velocity;
    public float jump;

    private void Update()
    {
        if (characterController.isGrounded && Velocity.y < 0)
        {
            Velocity.y = 0;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        characterController.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump"))
        {
            Velocity.y = Mathf.Sqrt(jump * -2f * gravity);
        }

        Velocity.y += gravity * Time.deltaTime;
        characterController.Move(Velocity * Time.deltaTime);
    }
}
