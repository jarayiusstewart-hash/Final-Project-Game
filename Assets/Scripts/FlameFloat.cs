
using UnityEngine;

public class FlameFloat : MonoBehaviour
{
    public float floatHeight = 0.12f;
    public float floatSpeed = 2f;
    public float swayAmount = 0.08f;
    public float swaySpeed = 1.5f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.localPosition;
    }

    void Update()
    {
        float verticalOffset =
            Mathf.Sin(Time.time * floatSpeed) * floatHeight;

        float horizontalOffset =
            Mathf.Sin(Time.time * swaySpeed) * swayAmount;

        transform.localPosition = startPosition +
            new Vector3(horizontalOffset, verticalOffset, 0f);
    }
}
