using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; //movement speed defaulted to 5f

    public Animator animator; //variable to hold animator

    Vector2 movement; //store movement data

    public Rigidbody2D rb; //reference to rigidbody
    // Start is called before the first frame update
    void Start()
    {
        //get the animator component
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal"); //store x axis
        movement.y = Input.GetAxisRaw("Vertical"); //store y=axis

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
