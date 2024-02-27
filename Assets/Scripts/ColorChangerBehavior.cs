using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangerBehavior : MonoBehaviour
{
    [SerializeField] private GameObject _testCube;


    void Start()
    {
        _testCube = GameObject.Find("ColorTestCube");
        if (_testCube == null)
        {
            Debug.Log("Test Cube is null");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    _testCube.GetComponent<MeshRenderer>().material.color = Color.red;
        //    Debug.Log("R has been pressed");
        //}

        //if (Input.GetKeyDown(KeyCode.G))
        //{
        //    _testCube.GetComponent<MeshRenderer>().material.color = Color.green;
        //}

        //if (Input.GetKeyDown(KeyCode.C))
        //{
        //    _testCube.GetComponent<MeshRenderer>().material.color = Color.cyan;
        //}

        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    _testCube.GetComponent<MeshRenderer>().material.color = Color.white;
        //}

        //if (Input.GetKeyDown(KeyCode.B))
        //{
        //    _testCube.GetComponent<MeshRenderer>().material.color = Color.black;
        //}
    }

    public void FindShip()
    {
        
    }
}
