using UnityEngine;

public class CameraFollowRigid : MonoBehaviour
{
        public Transform target;
        public Vector3 offset = new Vector3(0, 0, -10);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position + offset;
        transform.LookAt(target);
    }
}
// NOTE TO SELF: apply this script to your CAMERA, not your player GameObject