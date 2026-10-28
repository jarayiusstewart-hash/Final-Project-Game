
using UnityEngine;

public class ObjectiveReveal : MonoBehaviour
{
    public Renderer objectiveRenderer;
    public Light objectiveLight;

    private bool revealed = false;

    void Start()
    {
        if (objectiveRenderer == null)
            objectiveRenderer = GetComponent<Renderer>();

        // Hide the objective until the flame reaches it.
        if (objectiveRenderer != null)
            objectiveRenderer.enabled = false;

        if (objectiveLight != null)
            objectiveLight.enabled = false;
    }

    public void Reveal()
    {
        if (revealed)
            return;

        revealed = true;

        if (objectiveRenderer != null)
            objectiveRenderer.enabled = true;

        if (objectiveLight != null)
            objectiveLight.enabled = true;

        Debug.Log("The flame has revealed the objective!");
    }
}
