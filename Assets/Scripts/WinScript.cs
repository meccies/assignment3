using UnityEngine;

public class WinScript : MonoBehaviour
{
    public Transform playerTransform;
    public Transform winTransform;
    public float winDistance = 1.5f; // Distance threshold to trigger win condition

    
    public bool hasWon = false; // Flag to track if the player has won

    private void Update()
    {
        if (hasWon)
        {
            return; // Exit if the player has already won
        }

        // Check the distance between the player and the win object
        float distance = Vector3.Distance(playerTransform.position, winTransform.position);

        // If the distance is less than or equal to the win distance, trigger win condition
        if (distance <= winDistance)
        {
            WinGame();
            // You can add additional logic here, such as loading a new scene or displaying a win message
        }
    }

    void WinGame()
    {
        hasWon = true; // Set the win flag to true
        Debug.Log("You Win!");
        // You can add additional logic here, such as loading a new scene or displaying a win message
    }


}
