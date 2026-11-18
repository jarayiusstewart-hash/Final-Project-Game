
using UnityEngine;
using UnityEngine.AI;

public class NavMeshDiagnostic : MonoBehaviour
{
    void Start()
    {
        NavMeshTriangulation mesh = NavMesh.CalculateTriangulation();

        Debug.Log("NavMesh triangles: " +
                  mesh.indices.Length / 3);

        Vector3 testPosition = Vector3.zero;

        if (NavMesh.SamplePosition(
            testPosition,
            out NavMeshHit hit,
            2f,
            NavMesh.AllAreas))
        {
            Debug.Log("NavMesh found near the starting floor!");
            Debug.Log("Nearest point: " + hit.position);
        }
        else
        {
            Debug.LogWarning(
                "No NavMesh found near the starting floor."
            );
        }
    }
}
