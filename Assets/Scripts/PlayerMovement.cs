using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;

    Vector2 movement;
    Vector2 lastDirection;
    public float moveSpeed = 5f;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (movement.sqrMagnitude < .01)
        {
            lastDirection.x = anim.GetFloat("Horizontal");
            lastDirection.y = anim.GetFloat("Vertical");

            anim.SetFloat("Horizontal", lastDirection.x);
            anim.SetFloat("Vertical", lastDirection.y);
        }
        else
        {
            anim.SetFloat("Horizontal", movement.x);
            anim.SetFloat("Vertical", movement.y);
        }

        anim.SetFloat("Speed",movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.deltaTime);
    }
}
