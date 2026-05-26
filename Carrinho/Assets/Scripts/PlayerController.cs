using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputActionAsset inputActions;

    private InputAction moveAction;

    private float speed = 20f;
    private float turnSpeed = 45f;

    private Vector2 movement;

    void Awake()
    {
        moveAction = inputActions.FindAction("Move");
    }

    void Update()
    {
        // Read movement input
        movement = moveAction.ReadValue<Vector2>();

        // Forward/backward movement
        transform.Translate (Vector3.forward * movement.y * speed * Time.deltaTime);

        // Left/right rotation
        transform.Rotate (Vector3.up * movement.x * turnSpeed * Time.deltaTime);
    }
}