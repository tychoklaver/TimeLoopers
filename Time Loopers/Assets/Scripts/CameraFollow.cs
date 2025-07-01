using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Tooltip("Target to follow, usually player.")]
    public Transform target;

    public float smoothSpeed = 0.125f;

    public Vector3 offset;

    // Update is called once per frame
    private void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPos = target.position + offset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
        transform.position = smoothedPos;
    }
}
