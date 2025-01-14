using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Speed of the player's movement
    public float moveSpeed = 5f;

    // Reference to the Rigidbody2D component
    private Rigidbody2D rb;

    // Store player input
    private Vector2 movement;

    // Start is called once before the first execution of Update
    void Start()
    {
        // Get the Rigidbody2D component attached to the player
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from the player
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

    // FixedUpdate is called on a fixed interval, suitable for physics updates
    void FixedUpdate()
    {
        // Move the player using Rigidbody2D
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
