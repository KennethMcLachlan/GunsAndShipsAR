using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    public string gemColorName = "";

    public Material targetMaterial;

    private Color _originalEmissionColor;

    private void Start()
    {
        //Cache the gem's initial emission color
        _originalEmissionColor = targetMaterial.GetColor("_EmissionColor");

        //Set the gem's emission color to black
        targetMaterial.SetColor("_EmissionColor", Color.black);
    }

    public void ChangeEmission(bool isEmitting)
    {
        if (isEmitting == true)
        {
            //Make the gem emissive
            targetMaterial.SetColor("_EmissionColor", _originalEmissionColor);
        }
        else
        {
            //Make this gem unemissive
            targetMaterial.SetColor("_EmissionColor", Color.black);
        }
    }
}
