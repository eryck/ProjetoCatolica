using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{

    private AudioSource _audio;
    //Cria um Array de Audios
    //public AudioClip[] _audioFiles;

    // Use this for initialization
    void Start()
    {
        _audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!_audio.isPlaying)
        {
            _audio.Play();
        }

    }
}
