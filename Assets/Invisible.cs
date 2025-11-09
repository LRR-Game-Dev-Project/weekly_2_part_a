using UnityEngine;

public class Invisible: MonoBehaviour
{
    [Header("General Settings")]
    [SerializeField] private KeyCode button = KeyCode.Space;// Make the object invisible on start

    private Renderer rend;// Renderer component for the object

// Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<Renderer>();// Get the Renderer component
        if (rend == null)// Check if the Renderer component exists
        {
            Debug.LogError("No Renderer found");
        }
    }
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(button) && rend != null)// Check if the button is pressed and Renderer exists
        {
            rend.enabled = !rend.enabled;// Toggle the visibility of the object
        }
    }
}
