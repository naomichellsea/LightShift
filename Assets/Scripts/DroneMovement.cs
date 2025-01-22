using UnityEngine;

public class DroneMovement : MonoBehaviour
{
    public float speed = 5f;       // Speed of the drone
    public float moveRange = 10f; // Range of movement from the start position

    private Vector3 startPosition; // The initial position of the drone
    private Vector2 targetPosition; // The current target position
    private bool movingForward = true; // Direction of movement

    void Start()
    {
        // Store the initial position of the drone
        startPosition = transform.position;

        // Set the first target position to the right of the start position
        targetPosition = startPosition + Vector3.right * moveRange;
    }

    void Update()
    {
        // Move the drone toward the current target position
        transform.position = Vector3.MoveTowards(
            transform.position,
            targetPosition,
            speed * Time.deltaTime
        );

        if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
        {
            // Reverse direction and update the target position
            movingForward = !movingForward;
            targetPosition = movingForward
                ? startPosition + Vector3.right * moveRange // Move to the right
                : startPosition; // Move back to the original position
        }
    }
}
