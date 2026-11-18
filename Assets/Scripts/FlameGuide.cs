
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;

public class FlameGuide : MonoBehaviour
{
    public Transform player;
    public Transform destination;
    public Transform[] waypoints;

    public float guideSpeed = 3f;
    public float stopDistance = 1.5f;
    public float hoverHeight = 1.8f;
    public LayerMask wallLayers;
    public float collisionRadius = 0.12f;

    private bool isGuiding = false;
    private bool hasReachedDestination = false;

    private Transform originalParent;
    private Vector3 originalLocalPosition;
    private FlameFloat flameFloat;
    private NavMeshPath navigationPath;

    private int currentCornerIndex = 0;

    void Start()
    {
        originalParent = transform.parent;
        originalLocalPosition = transform.localPosition;

        flameFloat = GetComponent<FlameFloat>();

        navigationPath = new NavMeshPath();
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
        if (navigationPath == null ||
            navigationPath.corners.Length == 0)
            return;

        Vector3 cornerPosition =
            navigationPath.corners[currentCornerIndex];

        Vector3 targetPosition = new Vector3(
            cornerPosition.x,
            hoverHeight,
            cornerPosition.z
        );
        Vector3 direction = targetPosition - transform.position;

        float moveDistance = Mathf.Min(
            guideSpeed * Time.deltaTime,
            direction.magnitude
        );

        if (direction.sqrMagnitude > 0.0001f &&
            Physics.SphereCast(
                transform.position,
                collisionRadius,
                direction.normalized,
                out RaycastHit wallHit,
                moveDistance,
                wallLayers,
                QueryTriggerInteraction.Ignore
            ))
        {
            Debug.LogWarning("Wall blocking flame movement!");
            return;
        }
        transform.position = Vector3.MoveTowards(
            transform.position,
            targetPosition,
            guideSpeed * Time.deltaTime
        );

        // Reveal the objective when the flame reaches it.
        if (Vector3.Distance(transform.position, targetPosition)
            <= 0.05f)
        {
            if (currentCornerIndex < navigationPath.corners.Length - 1)
            {
                currentCornerIndex++;
                return;
            }
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

    bool CalculatePath()
    {
        NavMeshHit startHit;

        Vector3 searchPosition = new Vector3(
        transform.position.x,
        0f,
        transform.position.z
);

        bool foundStart = NavMesh.SamplePosition(
            searchPosition,
            out startHit,
            5f,
            NavMesh.AllAreas
        );

        if (!foundStart)
            
        {
            Debug.LogWarning("No NavMesh near flame at " + searchPosition
        );
            return false;
        }
        NavMeshHit destinationHit;

        bool foundDestination = NavMesh.SamplePosition(
            destination.position,
            out destinationHit,
            5f,
            NavMesh.AllAreas
        );

        if (!foundDestination)
        {
            Debug.LogWarning("Objective is not near the NavMesh!");
            return false;
        }
        bool pathFound = NavMesh.CalculatePath(
            startHit.position,
            destinationHit.position,
            NavMesh.AllAreas,
            navigationPath
);
        if (!pathFound || navigationPath.status != NavMeshPathStatus.PathComplete)
        {
            Debug.LogWarning("No complete path to the objective!");
            return false;
        }
        currentCornerIndex = 0;

        Debug.Log("Complete NavMesh path found!");
        return true;
    }
    void StartGuiding()
    {
        if (destination == null)
        {
            Debug.LogWarning("No destination assigned!");
            return;
        }
        if (!CalculatePath())
        {
            Debug.LogWarning("The flame cannot find a valid route!");
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
