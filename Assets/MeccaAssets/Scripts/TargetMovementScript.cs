using UnityEngine;

public class TargetMovementScript : MonoBehaviour
{
    public float targetSpeed = 5;
    public Transform position;
    
    void Start()
    {   
        
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(h,0,v);
        transform.Translate(move * targetSpeed * Time.deltaTime);
      
    }
}