using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtBehavior : MonoBehaviour
{
    public Transform mainCamera;
    private GameObject _objectSample;

    private void Start()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Transform>();

        if (mainCamera != null )
        {
            Debug.Log("Main camera has been found");
        }
    }

    private void Update()
    {
        this.transform.LookAt(mainCamera);
    }
}
