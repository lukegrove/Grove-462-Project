using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController characterController;
    public Animator anim;
    public Vector3 Velocity;
    public float speed;
    public float gravity = -9.81f;
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
            anim.SetBool("isJumping", true);
            Velocity.y = Mathf.Sqrt(jump * -2f * gravity);
            StartCoroutine(coroutine());
        }

        IEnumerator coroutine()
        {
            yield return new WaitForSeconds(0.2f);
            anim.SetBool("isJumping", false);
        }

        Velocity.y += gravity * Time.deltaTime;
        characterController.Move(Velocity * Time.deltaTime);
    }
}
