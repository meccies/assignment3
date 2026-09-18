using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The target the camera will follow
    public Vector3 offset = new Vector3(0, 5, -10); // Offset from the target    

    void LateUpdate()
    {
       transform.position = target.position + offset; // Update camera position based on target position and offset
       transform.LookAt(target); // Make the camera look at the target
    }

}
