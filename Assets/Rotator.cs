using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Header("General Settings")]
    [SerializeField] private Vector3 rotationAxis = Vector3.up;// Axis of rotation
    [SerializeField] private float rotationSpeed = 30f;// degrees per second


    void Update()
    {        
        float time = Time.deltaTime;// Time since last frame
        transform.Rotate(rotationAxis.normalized, rotationSpeed * time);// Rotate around axis
    }
}
