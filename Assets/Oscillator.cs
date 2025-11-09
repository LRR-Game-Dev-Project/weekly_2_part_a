using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [Header("General Settings")]// General settings for oscillation
    [SerializeField] private Vector3 movementDir = new Vector3(1f, 0f, 0f);
    [SerializeField] private float amplitude = 3f;//max displacement from center
    [SerializeField] private float period = 2f;//time for one complete cycle

    
    [Header("Optional Controls")]// Optional controls for customization
    [SerializeField, Range(0f, 2f)] private float speedMultiplier = 1f; // controls speed
    [SerializeField] private bool useCosine = false; // to change phase(phase is shift in wave)

    private Vector3 centerPosition;
    private float timePassed = 0f;

    void Start()
    {
        centerPosition = transform.position;// Store initial position as center
    }

    void Update()
    {
        if (period <= Mathf.Epsilon) return;// Prevent division by zero

        timePassed += Time.deltaTime * speedMultiplier;// Adjust time based on speed multiplier

        float angle = (timePassed / period) * Mathf.PI * 2f;//compute angle in radians
        float rawWave = useCosine ? Mathf.Cos(angle) : Mathf.Sin(angle);// Choose between sine and cosine wave(to simulate "real" movement")

        Vector3 offset = movementDir.normalized * amplitude * rawWave;// Calculate offset of movement
        transform.position = centerPosition + offset;// Update position
    }
}
