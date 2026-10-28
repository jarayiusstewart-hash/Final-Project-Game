
using UnityEngine;
using UnityEngine.InputSystem;

public class FlameGuide : MonoBehaviour
{
    public Transform player;
    public Transform destination;

    public float guideSpeed = 3f;
    public float stopDistance = 1.5f;
    public float hoverHeight = 1.8f;

    private bool isGuiding = false;
    private bool hasReachedDestination = false;

    private Transform originalParent;
    private Vector3 originalLocalPosition;
    private FlameFloat flameFloat;

    void Start()
    {
        originalParent = transform.parent;
        originalLocalPosition = transform.localPosition;

        flameFloat = GetComponent<FlameFloat>();
    }

    void Update()
    {
        if (Keyboard.current != null &&
            Keyboard.current.gKey.wasPressedThisFrame)
        {
            if (isGuiding)
                ReturnToPlayer();
            else
                StartGuiding();
        }
    }

    void LateUpdate()
    {
        if (!isGuiding || destination == null ||
            hasReachedDestination)
            return;

        Vector3 targetPosition = new Vector3(
            destination.position.x,
            hoverHeight,
            destination.position.z
        );

        transform.position = Vector3.MoveTowards(
            transform.position,
            targetPosition,
            guideSpeed * Time.deltaTime
        );

        // Reveal the objective when the flame reaches it.
        if (Vector3.Distance(transform.position, targetPosition)
            <= stopDistance)
        {
            hasReachedDestination = true;

            ObjectiveReveal reveal =
                destination.GetComponent<ObjectiveReveal>();

            if (reveal != null)
            {
                reveal.Reveal();
            }
            else
            {
                Debug.LogWarning(
                    "ObjectiveReveal script not found on destination!"
                );
            }

            Debug.Log("The flame has reached its destination.");
        }
    }

    void StartGuiding()
    {
        if (destination == null)
        {
            Debug.LogWarning("No destination assigned!");
            return;
        }

        isGuiding = true;
        hasReachedDestination = false;

        // Disable floating animation during guidance.
        if (flameFloat != null)
            flameFloat.enabled = false;

        // Detach flame from player.
        transform.SetParent(null, true);

        // Keep flame above the ground.
        Vector3 position = transform.position;
        position.y = hoverHeight;
        transform.position = position;

        Debug.Log("The flame is guiding you...");
    }

    void ReturnToPlayer()
    {
        isGuiding = false;
        hasReachedDestination = false;

        // Return flame to player's shoulder.
        transform.SetParent(originalParent, false);
        transform.localPosition = originalLocalPosition;

        // Restore floating animation.
        if (flameFloat != null)
            flameFloat.enabled = true;

        Debug.Log("The flame has returned.");
    }
}
