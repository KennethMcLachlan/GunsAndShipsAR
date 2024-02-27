using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hostess_ShipIntro : MonoBehaviour
{
    [SerializeField] private GameObject _selectShipButton;
    [SerializeField] private GameObject _shipText;

    public AudioSource _audioSource;
    [SerializeField] private AudioSource _shipIntroVoice;
    [SerializeField] private AudioClip[] _voiceOvers;
    private AudioClip _playedVoice;

    private bool _hostessIsActive;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        StartCoroutine(ShipIntroductionRoutine());
    }

    private IEnumerator ShipIntroductionRoutine()
    {
        yield return new WaitForSeconds(1F);

        //MAKE iNTRODUCTIONS
        _shipIntroVoice.Play();

        yield return new WaitForSeconds(8f);

        _hostessIsActive = true;
        if (_hostessIsActive == true)
        {
            StartCoroutine(VoiceRoutine());
        }

        _selectShipButton.SetActive(true);
        _shipText.SetActive(true);
    }

    private IEnumerator VoiceRoutine()
    {
        while (_hostessIsActive == true)
        {
            yield return new WaitForSeconds(15f);

            int voices = Random.Range(0, _voiceOvers.Length);
            _playedVoice = _voiceOvers[voices];

            _audioSource.clip = _playedVoice;
            _audioSource.Play();
        }
    }
}
