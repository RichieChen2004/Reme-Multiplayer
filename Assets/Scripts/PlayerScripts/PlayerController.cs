using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    public Ingredient heldIngredient;
    private Storage nearbyStorage; // Keep track of the nearby Storage object

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        // Check for interaction input
        if (Input.GetKeyDown(KeyCode.E) && nearbyStorage != null)
        {
            nearbyStorage.executeAction(this);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if entering a Storage trigger
        if (other.CompareTag("Storage"))
        {
            nearbyStorage = other.GetComponent<Storage>();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Clear the reference when leaving the trigger
        if (other.CompareTag("Storage"))
        {
            nearbyStorage = null;
        }
    }
}
