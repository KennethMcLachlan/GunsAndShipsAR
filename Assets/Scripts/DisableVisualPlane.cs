using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class DisableVisualPlane : MonoBehaviour
{
    public MeshRenderer mesh;

    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }
    public void DisablePlaneVisibility()
    {
        mesh.Equals(null);
    }

    public void EnablePlaneVisibility()
    {
        mesh.Equals(true);
    }
}
