using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta_Elevador : MonoBehaviour {


    private Animator _animation;
    private AudioSource _audio;
    public static bool _abrirPortaElevador = false;
    public static bool _fecharPortaElevador = false;

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
	void Update () {

        //Realiza a ação
        if (_abrirPortaElevador)
        {
            //Audio porta
            PlayAudio();

            //Abre a porta
            _animation.SetTrigger("Abrir");

            //Encerra a animação
            _abrirPortaElevador = false;
        }

        if (_fecharPortaElevador)
        {
            //Audio porta
            PlayAudio();

            //Fecha a porta
            _animation.SetTrigger("Fechar");

            //Encerra a animação
            _fecharPortaElevador = false;
        }
		
	}
}
