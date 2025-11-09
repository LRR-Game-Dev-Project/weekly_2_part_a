using UnityEngine;

public class Pump : MonoBehaviour
{
    [Header("General Settings")]

     [SerializeField] private float period = 1f;// Axis of rotation
    [SerializeField] private float small = 0.8f;// smallest scale
    [SerializeField] private float big = 1.3f;// largest scale

    //[SerializeField] private bool  = 30f;// degrees per second

    private Vector3 originalScale;
    private float timePassed = 0f;

    void Start()
    {// Store original scale
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {

        if (period <= Mathf.Epsilon) return;// Prevent division by zero
        timePassed += Time.deltaTime;// Time since last frame

        float angle = (timePassed / period) * Mathf.PI * 2f;//compute angle in radians
        float rawWave = Mathf.Sin(angle);// Sine wave for smooth pulsing

        float normalizedWave = (rawWave + 1f) / 2f;// Normalize to [0, 1]
        float scale = Mathf.Lerp(small, big, normalizedWave);// Interpolate between small and big
        transform.localScale = originalScale * scale;// Update scale
    }
}
