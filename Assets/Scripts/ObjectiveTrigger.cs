
using UnityEngine;

public class ObjectiveTrigger : MonoBehaviour
{
    public GameObject objectiveMessage;

    private bool completed = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered by: " + other.name);

        if (other.CompareTag("Player") && !completed)
        {
            completed = true;

            Debug.Log("Objective completed!");

            if (objectiveMessage != null)
            {
                objectiveMessage.SetActive(true);
            }
            else
            {
                Debug.LogWarning("ObjectiveMessage is not assigned!");
            }
        }
    }
}
