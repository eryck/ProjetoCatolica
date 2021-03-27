using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaIncendio : MonoBehaviour {

    private Animator _animation;
    private AudioSource _audio;
    public static bool _abrirPortaIncendio = false;
    public static bool _fecharPortaIncendio = false;

    // Use this for initialization
    void Start () {

        //associa os componentes de animação
        _animation = this.GetComponent<Animator>();

        //associa os componentes de audio
        _audio = this.GetComponent<AudioSource>();

    }

    //Audio da porta
    void PlayAudio()
    {
        _audio.Play();
    }

    // Update is called once per frame
    void Update()
    {

        //Realiza a ação
        if (_abrirPortaIncendio)
        {
            //Audio porta
            PlayAudio();

            //Abre a porta
            _animation.SetTrigger("Open");

            //Encerra a animação
            _abrirPortaIncendio = false;
        }

        if (_fecharPortaIncendio)
        {
            //Audio porta
            PlayAudio();

            //Fecha a porta
            _animation.SetTrigger("Close");

            //Encerra a animação
            _fecharPortaIncendio = false;
        }

    }
}
