using UnityEngine;

public class Invisible: MonoBehaviour
{
    [Header("General Settings")]
    [SerializeField] private KeyCode button = KeyCode.Space;// Make the object invisible on start

    private Renderer rend;// Renderer component for the object


    private void Start()
    {
        rend = GetComponent<Renderer>();
        if (rend == null)
        {
            Debug.LogError("No Renderer found");
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(button) && rend != null)
        {
            rend.enabled = !rend.enabled;// Toggle visibility
        }
    }
}
