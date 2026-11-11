
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class ObjectiveTrigger : MonoBehaviour
{
    public GameObject objectiveMessage;
    public GameObject restartHint;

    private bool completed = false;
    public float messageDuration = 5f;

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
                StartCoroutine(HideCompletionMessage());
                if (restartHint != null)
                {
                    restartHint.SetActive(true);
                }
            }
            else
            {
                Debug.LogWarning("ObjectiveMessage is not assigned!");
            }
        }
    }
    private void Update()
    {
        if (completed && Keyboard.current != null &&
            Keyboard.current.rKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().name
            );
        }
    }
    private System.Collections.IEnumerator HideCompletionMessage()
    {
        yield return new WaitForSeconds(messageDuration);

        if (objectiveMessage != null)
        {
            objectiveMessage.SetActive(false);
        }
    }
}
