
using UnityEngine;
using UnityEngine.InputSystem;

public class ControlsUI : MonoBehaviour
{
    public GameObject controlsText;
    public GameObject objectiveMessage;
    public GameObject controlsHint;

    public float displayTime = 10f;

    private float timer;
    private bool gameCompleted = false;

    void Start()
    {
        controlsText.SetActive(true);
        timer = displayTime;
    }

    void Update()
    {
        // Hide controls when the objective is completed.
        if (objectiveMessage.activeSelf)
        {
            gameCompleted = true;
            controlsText.SetActive(false);
            controlsHint.SetActive(false);
        }

        if (gameCompleted)
            return;

        // Automatically hide the instructions.
        if (controlsText.activeSelf)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                controlsText.SetActive(false);
            }
        }

        // Press H to show or hide the controls.
        if (Keyboard.current != null &&
            Keyboard.current.hKey.wasPressedThisFrame)
        {
            bool showControls = !controlsText.activeSelf;

            controlsText.SetActive(showControls);

            if (showControls)
            {
                timer = displayTime;
            }
        }
    }
}
