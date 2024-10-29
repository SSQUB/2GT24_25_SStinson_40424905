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

    public Text velocityText;
    private int mph=200;


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
    horizontalInput = Input.GetAxis("Horizontal");
    // forwardInput = Input.GetAxis("Vertical");
    float inputY = Input.GetAxis("Vertical"); //added to test moving vertically upwards

    //speed = 45.0f;

    Vector3 movement = new Vector3(0, inputY * speed * Time.deltaTime, 0);  //added to test moving vertically upwards
                                                                            // Apply the movement
    transform.position += movement;  //added to test moving vertically upwards

    // We will move the vehicle forward
    //  transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
    //We turn the vehicle
    transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        // Apply a constant force to the right (or left) to make the object drift
        Vector3 drift = Vector3.right * driftForce;
        rb.AddForce(drift*Time.deltaTime, ForceMode.Acceleration);


    }

    void FixedUpdate()
{

        mph = mph+1;

        //var mph = rigidbody.velocity.magnitude * 2.237;
        velocityText.text = "Velocity: " +mph.ToString();
       // velocityText.text = "Game Over ";

    }

}

