using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examinable : MonoBehaviour
{
    [SerializeField] private ExaminableManager _examinableManager;

    [SerializeField] public float examineScaleOffset = 1f;
    void Start()
    {
        _examinableManager = FindObjectOfType<ExaminableManager>();
        if (_examinableManager == null)
        {
            Debug.Log("Examinable Manager is NULL");
        }
    }

    public void RequestExamine()
    {
        _examinableManager.PerformExamine(this);
        Debug.Log("Examine has been requested");
    }

    public void RequestUnexamine()
    {
        _examinableManager.PerformUnexamine();
    }
}
