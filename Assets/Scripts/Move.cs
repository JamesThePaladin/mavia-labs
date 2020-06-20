using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject thisAlpha; //variable to store GameObject
    public Transform tf; // A variable to hold our Transform component
    Animator playerAnimator;
    public float speed; // variable for vector magnitude
    public float xDelta; // variable for x-axis
    public float yDelta; // variable for y-axis
    private Boolean MoveEnabled = true; //boolean for disabling/enabling movement

    void Start()
    {
        // Get the Transform Component
        tf = GetComponent<Transform>();
        //get the animator component
        playerAnimator = GetComponent<Animator>();
    }
    void Update()
    {
        //set code for the animator bro 6/19/20

        //toggle input handlers
        if (Input.GetKeyDown("p"))
        {
            if (MoveEnabled)
            {
                MoveEnabled = false;
            }

            else 
            {
                MoveEnabled = true;
            }
        }

        if (MoveEnabled)
        {   //if the shift key is pressed down, move 1 unit
            if (Input.GetKey("left shift") | Input.GetKey("right shift")) 
            {
                if (Input.GetKeyDown("w") | Input.GetKeyDown("up"))
                {
                    Vector3 myVector = new Vector3(0, 1, 0); // create vector to add
                    myVector = myVector.normalized; // You could also call the function myVector.Normalize();
                    tf.position += (myVector * speed); // change position and add magnitude
                }

                if (Input.GetKeyDown("a") | Input.GetKeyDown("left"))
                {
                    Vector3 myVector = new Vector3(-1, 0, 0); // create vector to add
                    myVector = myVector.normalized; // You could also call the function myVector.Normalize();
                    tf.position += (myVector * speed); // change position and add magnitude
                }

                if (Input.GetKeyDown("s") | Input.GetKeyDown("down"))
                {
                    Vector3 myVector = new Vector3(0, -1, 0); // create vector to add
                    myVector = myVector.normalized; // You could also call the function myVector.Normalize();
                    tf.position += (myVector * speed); // change position and add magnitude
                }

                if (Input.GetKeyDown("d") | Input.GetKeyDown("right"))
                {
                    Vector3 myVector = new Vector3(1, 0, 0); // create vector to add
                    myVector = myVector.normalized; // You could also call the function myVector.Normalize();
                    tf.position += (myVector * speed); // change position and add magnitude
                }
            }

            //otherwise move as normal
            else
            {
                if (Input.GetKey("w") | Input.GetKey("up"))
                {
                    Vector3 myVector = new Vector3(0, yDelta, 0); // create vector to add
                    myVector = myVector.normalized; // You could also call the function myVector.Normalize();
                    tf.position += (myVector * speed); // change position and add magnitude
                }

                if (Input.GetKey("a") | Input.GetKey("left"))
                {
                    Vector3 myVector = new Vector3(xDelta, 0, 0); // create vector to add
                    myVector = myVector.normalized; // You could also call the function myVector.Normalize();
                    tf.position -= (myVector * speed); // change position and add magnitude
                }

                if (Input.GetKey("s") | Input.GetKey("down"))
                {
                    Vector3 myVector = new Vector3(0, yDelta, 0); // create vector to add
                    myVector = myVector.normalized; // You could also call the function myVector.Normalize();
                    tf.position -= (myVector * speed); // change position and add magnitude
                }

                if (Input.GetKey("d") | Input.GetKey("right"))
                {
                    Vector3 myVector = new Vector3(xDelta, 0, 0); // create vector to add
                    myVector = myVector.normalized; // You could also call the function myVector.Normalize();
                    tf.position += (myVector * speed); // change position and add magnitude
                }
            }

            //Return alpha to (0, 0, 0)
            if (Input.GetKeyDown("space"))
            {
                tf.position = new Vector3(0, 0, 0);
            }
        }

        //exit application with escape key
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            Application.Quit();
        }

        //make thisShip inactive
        if (Input.GetKeyDown("q")) 
        {
            thisAlpha.SetActive(false);
        }
    }
}
