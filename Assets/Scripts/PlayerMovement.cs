using NUnit.Framework;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public Transform playerTransform;
    public float jumpCount = 0f;  
    public bool isGrounded = true; // Flag to check if the player is grounded 
    public bool isSprinting = false; // Flag to check if the player is sprinting     
    public WinScript winScript; // Reference to the WinScript component
    public bool hasWon = false; // Flag to track if the player has won
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 move = Vector3.zero;
        
        hasWon = winScript.hasWon; // Initialize hasWon with the value from WinScript
        if (hasWon)
        {
            return;
            //Debug.Log("Has won in movement script =" + hasWon); // Exit if the player has already won
        }   

        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 10f; // Increase move speed when sprinting
        }   
        else
        {
            moveSpeed = 5f; // Reset move speed when not sprinting 
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
       {
           //move += Vector3.up;
           GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
              isGrounded = false; // Set isGrounded to false when jumping

       }
        if (Input.GetKey(KeyCode.W))
        {
           move += Vector3.forward;
       }
        if (Input.GetKey(KeyCode.S))
        {
           move += Vector3.back;
       }
       if (Input.GetKey(KeyCode.A))
       {
           move += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
           move += Vector3.right;
       }
        
       transform.Translate(move * moveSpeed * Time.deltaTime, Space.World);

       if (isGrounded)
       {
           jumpCount = 0; // Reset jump count when grounded
       }

        
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Ground")
        {
             isGrounded = true;
            // jumpCount = 0; // Reset jump count when grounded
            Debug.Log("Has hit ground isGrounded = " + isGrounded);
        }
            
        }
}
