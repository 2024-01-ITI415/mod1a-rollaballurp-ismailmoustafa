using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody rb;
    private float movementX;
    private float movementY;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        movementX = Input.GetAxis("Horizontal");
        movementY = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }
}
