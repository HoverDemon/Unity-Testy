using UnityEngine;

public class TargetMove : MonoBehaviour
{

    public Vector3 minVaule, maxValue;
    public float speed;

    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        Vector3 BoundPos = new Vector3(
            Mathf.Clamp(transform.position.x, minVaule.x, maxValue.x),
            Mathf.Clamp(transform.position.y, minVaule.y, maxValue.y),
            Mathf.Clamp(transform.position.z, minVaule.z, maxValue.z));

        Vector3 smoothValue = Vector3.Lerp(transform.position, BoundPos, speed * Time.deltaTime);
        transform.position = smoothValue;
    }
}