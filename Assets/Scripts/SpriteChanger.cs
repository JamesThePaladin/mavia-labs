using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{

    // Declare our variables
    private SpriteRenderer theRenderer; // variable for our renderer
    public Color spriteColor; // variable for our Color

    // Use this for initialization
    void Start()
    {
        // Load the SpriteRenderer component from the same object this component is on.
        theRenderer = gameObject.GetComponent<SpriteRenderer>();
        // Change the color from our color picker so that the alpha is 1
        spriteColor.a = 1.0f;
        // As long as theRenderer has been set
        if (theRenderer != null)
        {
            // Change the "color" value of the SpriteRenderer component to our new color
            theRenderer.color = spriteColor;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}