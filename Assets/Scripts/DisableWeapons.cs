using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class DisableWeapons : MonoBehaviour
{
    public GameObject[] weapons;

    public void WeaponDisabler()
    {
        weapons = GameObject.FindGameObjectsWithTag("Weapons");

        foreach (var weapon in weapons)
        {
            if (weapon != null)
            {
                weapon.SetActive(false);
            }
        }
    }
}
