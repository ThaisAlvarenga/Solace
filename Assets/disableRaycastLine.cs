using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class disableRaycastLine : MonoBehaviour
{
   // Reference to the XR Visual Raycast Line game component
    private XRInteractorLineVisual visualRaycastLine;

    public void disableRaycast()
    {
        // Get a reference to the XR Visual Raycast Line game component
        visualRaycastLine = GetComponent<XRInteractorLineVisual>();

        // Disable the XR Visual Raycast Line game component
        visualRaycastLine.enabled = false;
    }
}
