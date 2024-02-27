using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    private AudioSource _assaultRifleSFX;
    private AudioSource _pistolSFX;
    private AudioSource _shotgunSFX;
    private AudioSource _sniperSFX;

    private void Start()
    {
        _assaultRifleSFX = GameObject.Find("SFX_AssaultRifle").GetComponent<AudioSource>();
        _pistolSFX = GameObject.Find("SFX_Pistol").GetComponent<AudioSource>();
        _shotgunSFX = GameObject.Find("SFX_Shotgun").GetComponent<AudioSource>();
        _sniperSFX = GameObject.Find("SFX_Sniper").GetComponent<AudioSource>();

        if (_assaultRifleSFX == null)
        {
            Debug.Log("SFX is NULL");
        }
    }

    public void AssaultRifle()
    {
        _assaultRifleSFX.Play();
    }

    public void Pistol()
    {
       _pistolSFX.Play();
    }

    public void Shotgun()
    {
        _shotgunSFX.Play();
    }

    public void Sniper()
    {
        _sniperSFX.Play();
    }
}
