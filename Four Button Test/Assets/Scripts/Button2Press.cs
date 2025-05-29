using UnityEngine;
using UnityEngine.UI;

public class Button2Press : MonoBehaviour
{
    // Reference to cube's renderer
    public Renderer cubeRenderer; 

    // Function to color cube
    public void OnButtonClicked()
    {
        Debug.Log("Button was clicked"); 
        if (cubeRenderer != null)
        {
            cubeRenderer.material.color = Color.red; // Change the cube's color
        }
    }
}