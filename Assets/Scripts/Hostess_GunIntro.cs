using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hostess_GunIntro : MonoBehaviour
{
    [SerializeField] private GameObject _selectModeButton;
    [SerializeField] private GameObject _selectModeInstructions;
    private GameObject _host;

    [SerializeField] AudioSource _audioSource;
    [SerializeField] private AudioSource _gunIntroVoice;
    [SerializeField] private AudioClip[] _hostVoiceOvers;
    private AudioClip _playedVoice;

    private bool _hostIsActive;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        StartCoroutine(GunIntroductionRoutine());
    }

    //public void HostIsPlaced()
    //{
    //    _hostIsPlaced = true;
    //    if (_hostIsPlaced == true)
    //    {
    //        _introCanStart = true;
    //    }
    //}

    //public void StartGunIntro()
    //{
    //    if (_introCanStart == true)
    //    {
    //        StartCoroutine(GunIntroductionRoutine());
    //    }
    //}

    private IEnumerator GunIntroductionRoutine()
    {
        yield return new WaitForSeconds(1f);

        _gunIntroVoice.Play();

        yield return new WaitForSeconds(8f);

        _hostIsActive = true;
        if (_hostIsActive == true)
        {
            StartCoroutine(HostVoiceRoutine());
        }
        _selectModeButton.SetActive(true);
        _selectModeInstructions.SetActive(true);
    }

    private IEnumerator HostVoiceRoutine()
    {
        while (_hostIsActive == true)
        {
            yield return new WaitForSeconds(15f);

            int voices = Random.Range(0, _hostVoiceOvers.Length);
            _playedVoice = _hostVoiceOvers[voices];

            _audioSource.clip = _playedVoice;
            _audioSource.Play();

        }
    }
    //public void StartShipIntro()
    //{
    //    StartCoroutine(ShipIntroductionRoutine());
    //}

    //private IEnumerator ShipIntroductionRoutine()
    //{
    //    yield return new WaitForSeconds(1f);

    //    //make introductions

    //    yield return new WaitForSeconds(1f);
    //}
}
