using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate() //run right after update
    {
        transform.position = target.position + offset;
    }
}
