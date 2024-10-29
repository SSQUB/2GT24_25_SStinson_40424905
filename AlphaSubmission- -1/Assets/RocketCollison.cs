using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RocketCollison : MonoBehaviour
{
    public Text countText;

    public Text velocityText;


    void OnTriggerEnter(Collider other)
    {

        // Detect if the Rocket object has hit the ground
        if (other.gameObject.tag=="Ground")
        {
           //Now that the rocket has landed, display Game Over in UI
            countText.text = "Game Over ";

            // Start the coroutine for a delay before the game is now terminated
            StartCoroutine(QuitAfterDelay());


        }
    }


    // Coroutine to handle the delay before game is terminated
    IEnumerator QuitAfterDelay()
    {


        // Wait for 5 seconds from Game Over is displayed, until terminating the game
        yield return new WaitForSeconds(5);

        // Quit/terminate the application
        Application.Quit();
    }

}

