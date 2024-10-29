using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RocketCollison : MonoBehaviour
{
    public Text countText;

    public Text velocityText;

    private int count;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Ground")
        {
            //print("Hit the ground");
            count=0;
            //countText.text = "Count: " + count.ToString();
            countText.text = "Game Over ";



            // Start the coroutine for the delay
            StartCoroutine(QuitAfterDelay());



            //Application.Quit();
        }
    }


    // Coroutine to handle the delay before quitting
    IEnumerator QuitAfterDelay()
    {


        // Wait for 5 seconds
        yield return new WaitForSeconds(5);

        // Quit the application
        Application.Quit();
    }

}

