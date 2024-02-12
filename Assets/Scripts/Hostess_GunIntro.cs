using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hostess_GunIntro : MonoBehaviour
{
    [SerializeField] private GameObject _selectWeaponButton;

    private void Update()
    {
        
    }
    public void StartGunIntro()
    {
        StartCoroutine(GunIntroductionRoutine());
    }

    private IEnumerator GunIntroductionRoutine()
    {
        yield return new WaitForSeconds(1f);

        //Make Introductions

        yield return new WaitForSeconds(1f);

        _selectWeaponButton.SetActive(true);
    }
}
