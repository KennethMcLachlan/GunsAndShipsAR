using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class DirectorManager : MonoBehaviour
{
    public PlayableDirector director;

    [SerializeField] private Animator _shipIdleAnimation;
    // Start is called before the first frame update
    void Start()
    {
        _shipIdleAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        director.stopped += OnPlayableDirectorStopped;
    }

    void OnPlayableDirectorStopped(PlayableDirector aDirector)
    {
        if (director == aDirector)
        {
            _shipIdleAnimation.SetTrigger("SetIdle");
            Debug.Log("Director has stopped");
        }
    }

    private void OnDisable()
    {
        director.stopped -= OnPlayableDirectorStopped;
    }
}
