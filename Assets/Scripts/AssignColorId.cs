using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignColorId : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int _id;

    [SerializeField] private ShipManager _shipManager;
    void Start()
    {
        _shipManager = GetComponent<ShipManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ColorIDNumber(int idNumber)
    {

    }
}
