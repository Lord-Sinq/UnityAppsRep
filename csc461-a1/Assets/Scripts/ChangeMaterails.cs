using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class MaterialChanger : MonoBehaviour
    {
    public GameObject targetGameObject; // Assign this in the Inspector

    void Start()
    {
        // Load the new material from Resources
        Material newMat = Resources.Load<Material>("Materials/ChangeMaterial");

        // Check if the material was loaded successfully
        if (newMat == null)
        {
            Debug.LogError("Material not found! Check the Resources folder and the name.");
            return;
        }

        if (targetGameObject == null)
        {
            Debug.LogError("Target GameObject not assigned! Please assign it in the Inspector.");
            return;
        }

        // Change the material of the Renderer
        targetGameObject.GetComponent<Renderer>().material = newMat;

        // Log the name of the GameObject being changed
        Debug.Log("Changed material of GameObject: " + targetGameObject.name);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
