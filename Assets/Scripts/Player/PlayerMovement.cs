using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator bodyAnim;
    public Animator clothesAnim;
    public Animator headPieceAnim;

    Vector2 movement;
    Vector2 lastDirection;
    public float moveSpeed = 5f;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        SetAnimations();

        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.deltaTime);
    }

    void SetAnimations()
    {
        if (movement.sqrMagnitude < .01)
        {
            lastDirection.x = bodyAnim.GetFloat("Horizontal");
            lastDirection.y = bodyAnim.GetFloat("Vertical");

            bodyAnim.SetFloat("Horizontal", lastDirection.x);
            bodyAnim.SetFloat("Vertical", lastDirection.y);

            clothesAnim.SetFloat("Horizontal", lastDirection.x);
            clothesAnim.SetFloat("Vertical", lastDirection.y);

            headPieceAnim.SetFloat("Horizontal", lastDirection.x);
            headPieceAnim.SetFloat("Vertical", lastDirection.y);
        }
        else
        {
            bodyAnim.SetFloat("Horizontal", movement.x);
            bodyAnim.SetFloat("Vertical", movement.y);

            clothesAnim.SetFloat("Horizontal", movement.x);
            clothesAnim.SetFloat("Vertical", movement.y);

            headPieceAnim.SetFloat("Horizontal", movement.x);
            headPieceAnim.SetFloat("Vertical", movement.y);
        }

        bodyAnim.SetFloat("Speed", movement.sqrMagnitude);
        clothesAnim.SetFloat("Speed", movement.sqrMagnitude);
        headPieceAnim.SetFloat("Speed", movement.sqrMagnitude);
    }
}
