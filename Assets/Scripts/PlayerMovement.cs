using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;       // Player movement speed
    public float jumpForce = 20f;     // Jumping force
    private Rigidbody2D rb;           // Reference to Rigidbody2D
    private bool isGrounded;          // Check if the player is on the ground
    private bool canDoubleJump;       // Allow double jump

    void Start()
    {
        // Get the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Handle movement (left/right)
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // Check for jump input
        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded)
            {
                Jump();               // First jump
                canDoubleJump = true; // Enable double jump
            }
            else if (canDoubleJump)
            {
                Jump();               // Second jump
                canDoubleJump = false;
            }
        }
    }

    private void Jump()
    {
        // Apply upward force for jumping
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player is touching a tile (ground)
        if (collision.gameObject.CompareTag("Tile"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Player is no longer touching the ground
        if (collision.gameObject.CompareTag("Tile"))
        {
            isGrounded = false;
        }
    }
}
