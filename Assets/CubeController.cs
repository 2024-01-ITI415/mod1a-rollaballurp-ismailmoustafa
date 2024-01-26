using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float rotationSpeed = 100.0f;
    public float bounceHeight = 0.5f;
    public float bounceSpeed = 5.0f;

    private float originalY;

    void Start()
    {
        // Store the original y position
        originalY = transform.position.y;
    }

    void Update()
    {
        // Spin the cube
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        // Bounce the cube
        float newY = originalY + Mathf.Sin(Time.time * bounceSpeed) * bounceHeight;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
