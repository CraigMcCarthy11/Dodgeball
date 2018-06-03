using UnityEngine;
using System.Collections;

// PlayerScript requires the GameObject to have a Rigidbody2D component

[RequireComponent(typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{
    public float playerSpeed = 4f;
    public int health = 10;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //When using rigidbodys/physics use FixedUpdate
    void FixedUpdate()
    {
        //GetAxis vs GetAxisRaw?
        //Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * playerSpeed;

        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

}