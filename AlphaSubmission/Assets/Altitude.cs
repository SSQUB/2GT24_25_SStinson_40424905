using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Altitude : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Reference to the Text component in the UI
    public Text altitudeText;

    // Update is called once per frame
    void Update()
    {

        // Check if the text component is assigned
        if (altitudeText != null)
        {
            // Get the Y position of the object
            float yPos = transform.position.y;

            // Display the Y position in the UI
            altitudeText.text = "Y Position: " + yPos; // F2 limits to 2 decimal places
            Debug.Log("Y Position: " + yPos);
        }

    }
}
