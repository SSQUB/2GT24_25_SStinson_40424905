using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{ 

//Private Variables
private float speed = 45.0f;
private float turnSpeed = 5.0f;
private float horizontalInput;
private float forwardInput;

public Text velocityText; //UI element used to display velocity of Rocket
private int mph=200; // Variable to hold Velocity MPH (Speed), initial speed set to 200MPH


public float driftForce = 1.0f;  // Controls the amount of sideways drift

private Rigidbody rb;


// Start is called before the first frame update
void Start()
{
    // Get the Rigidbody component attached to this object
    rb = GetComponent<Rigidbody>();

}


// Update is called once per frame
void Update()
{


    //This is where we get player input
    horizontalInput = Input.GetAxis("Horizontal"); // Take horixontal input from player
    float inputY = Input.GetAxis("Vertical"); // Take vertical input from player

    Vector3 movement = new Vector3(0, inputY * speed * Time.deltaTime, 0);  //Calculate vertically input to the Rocket
    transform.position += movement;  //Apply vertical movement to the rocket

    // Apply horizontal input to the Rocket 
    transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    // Apply a constant force to the right to make the Rocket drift to the right
    Vector3 drift = Vector3.right * driftForce;
    rb.AddForce(drift*Time.deltaTime, ForceMode.Acceleration);


    }

    void FixedUpdate()
{

        // The below code exists to test writing updating data to the UI,
        // a feature that exceeds the Alpha Submission features in the Game Design Document

        mph = mph+1; //Increment Velocity MPH currently displayed in UI

        // Write out the updated Velocity MPH to the UI
        velocityText.text = "Velocity: " +mph.ToString();

    }

}

