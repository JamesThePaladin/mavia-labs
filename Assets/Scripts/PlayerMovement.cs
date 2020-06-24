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
        movement.x = Input.GetAxis("Horizontal"); //store x axis
        movement.y = Input.GetAxis("Vertical"); //store y=axis

        animator.SetFloat("Horizontal", movement.x); //pass x to animator horizontal
        animator.SetFloat("Vertical", movement.y); //pass y to animator vertical
        animator.SetFloat("Speed", movement.sqrMagnitude); //pass magnitude to animator
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
