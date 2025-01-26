using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    public Ingredient heldIngredient;
    private Storage nearbyStorage; // Keep track of the nearby Storage object

    private Interactable nearbyInteractable;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        // Check for interaction input
        if (Input.GetKeyDown(KeyCode.E) && nearbyInteractable != null)
        {
            nearbyInteractable.executeAction(this);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Interactable"))
        {
            nearbyInteractable = other.GetComponent<Interactable>();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Interactable"))
        {
            nearbyInteractable = null;
        }
    }
}
