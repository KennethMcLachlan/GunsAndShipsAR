using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class DisableWeapons : MonoBehaviour
{
    public GameObject[] weapons;

    [SerializeField] private Examinable _examinableScript;

    public GameObject selectionVisualization;

    //private bool _isSearchingForWeapons;

    private bool _examineIsActive;

    private void Update()
    {
        weapons = GameObject.FindGameObjectsWithTag("Weapons");
        selectionVisualization = GameObject.FindGameObjectWithTag("SelectionViz");
    }
    public void WeaponDisabler()
    {
        foreach (var weapon in weapons)
        {
            if (weapon != null)
            {
                weapon.GetComponent<Examinable>();
                weapon.SetActive(false);
            }
        }
    }

    public void ExaminableToggler()
    {
        _examineIsActive = !_examineIsActive;

        if (_examineIsActive == true)
        {
            EnableExaminer();
            //Make text appear that says Examine mode is enabled?
        }

        if (_examineIsActive == false)
        {
            ExaminableDisabler();
        }
    }

    public void ExaminableDisabler()
    {
        foreach (var weapon in weapons)
        {
            if (weapon != null)
            {
                EnableARInteractors();

                var examineDisabler = weapon.gameObject.GetComponent<Examinable>();
                examineDisabler.enabled = false;
            }
        }
    }

    public void EnableExaminer()
    {
        foreach (var weapon in weapons)
        {
            if (weapon != null)
            {
                DisableARInteractors();

                var examineEnabler = weapon.gameObject.GetComponent<Examinable>();
                examineEnabler.enabled = true;
            }
        }
    }

    private void DisableARInteractors()
    {
        foreach(var weapon in weapons)
        {
            var translation = weapon.gameObject.GetComponent<ARTranslationInteractable>();
            translation.enabled = false;

            var scale = weapon.gameObject.GetComponent<ARScaleInteractable>();
            scale.enabled = false;

            var rotation = weapon.gameObject.GetComponent<ARRotationInteractable>();
            rotation.enabled = false;

            selectionVisualization.SetActive(false);
        }
    }

    private void EnableARInteractors()
    {
        foreach(var weapon in weapons)
        {
            var translation = weapon.gameObject.GetComponent<ARTranslationInteractable>();
            translation.enabled = true;

            var scale = weapon.gameObject.GetComponent<ARScaleInteractable>();
            scale.enabled = true;

            var rotation = weapon.gameObject.GetComponent<ARRotationInteractable>();
            rotation.enabled = true;

            selectionVisualization.SetActive(true);
        }
    }
}
