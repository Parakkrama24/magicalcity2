using UnityEngine;

public class SineMovement : MonoBehaviour
{
    [SerializeField] private float amplitude = 1f;   // Amplitude of the sine wave
    [SerializeField] private float frequency = 1f;   // Frequency of the sine wave
    [SerializeField] private float speed = 1f;       // Speed of movement

    private Vector3 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        // Calculate the new position based on the sine wave
        float y = startPosition.y + Mathf.Sin(Time.time * speed * frequency) * amplitude;

        // Apply the new position
        transform.position = new Vector3(startPosition.x, y, startPosition.z);
    }
}
