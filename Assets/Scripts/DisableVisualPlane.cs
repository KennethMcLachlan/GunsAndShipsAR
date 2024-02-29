using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class DisableVisualPlane : MonoBehaviour
{
    [SerializeField] private GameObject _ARDefaultPlane;

    private void ChangeMaterialAlpha()
    {
        if (_ARDefaultPlane != null)
        {
            Renderer renderer = _ARDefaultPlane.GetComponent<Renderer>();

            if (renderer != null )
            {
                Material material = renderer.material;

                if (material.HasProperty("_Color"))
                {
                    Color color = material.color;
                    color.a = 0f;
                    material.color = color;
                }
            }
        }
    }

    private void ChangeLineRenderer()
    {
        if (_ARDefaultPlane != null)
        {
            LineRenderer lineRenderer = _ARDefaultPlane.GetComponent<LineRenderer>();

            if (lineRenderer != null)
            {
                Color color = lineRenderer.material.color;
                color.a = 0f;
                lineRenderer.material.color = color;
            }
        }
    }

    public void DisablePlaneVisuals()
    {
        ChangeMaterialAlpha();
        ChangeLineRenderer();
    }
    
}
