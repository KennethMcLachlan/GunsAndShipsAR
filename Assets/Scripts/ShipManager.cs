using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipManager : MonoBehaviour
{
    public GameObject[] ships;

    [SerializeField] private int _colorID;

    public void ShipDisabler()
    {
        ships = GameObject.FindGameObjectsWithTag("Ships");

        foreach (var ship in ships)
        {
            if (ship != null)
            {
                ship.SetActive(false);
            }
        }
    }
    
    public void AssignColor()
    {
        ships = GameObject.FindGameObjectsWithTag("Ships");

        foreach (var ship in ships)
        {
            if (ship != null)
            {
                switch (_colorID)
                {
                    case 0:
                        ship.GetComponentInChildren<MeshRenderer>().material.color = Color.white;
                        break;
                    case 1:
                        ship.GetComponentInChildren<MeshRenderer>().material.color = Color.red;
                        break;
                    case 2:
                        ship.GetComponentInChildren<MeshRenderer>().material.color = Color.cyan;
                        break;
                    case 3:
                        ship.GetComponentInChildren<MeshRenderer>().material.color = Color.green;
                        break;
                    case 4:
                        ship.GetComponentInChildren<MeshRenderer>().material.color = Color.black;
                        break;

                }
            }
        }
    }

    public void AssignWhite()
    {
        _colorID = 0;
        AssignColor();
    }
    public void AssignRed()
    {
        _colorID = 1;
        AssignColor();
    }

    public void AssignCyan()
    {
        _colorID = 2;
        AssignColor();
    }

    public void AssignGreen()
    {
        _colorID = 3;
        AssignColor();
    }

    public void AssignBlack()
    {
        _colorID = 4;
        AssignColor();
    }

}
