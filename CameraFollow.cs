using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Camera cam;
    public Vector3 offsets;
    [Range(1, 10)]
    public float smoothness;
    public Vector3 minVaule, maxValue;

    private void FixedUpdate()
    {
        Follow();
    }

    void Follow()
    {
        Vector3 targetPos = target.position + offsets;
        Vector3 BoundPos = new Vector3(
            Mathf.Clamp(targetPos.x, minVaule.x, maxValue.x),
            Mathf.Clamp(targetPos.y, minVaule.y, maxValue.y),
            Mathf.Clamp(targetPos.z, minVaule.z, maxValue.z));

        Vector3 smoothValue = Vector3.Lerp(transform.position, BoundPos, smoothness * Time.deltaTime);
        transform.position = smoothValue;
    }
}
