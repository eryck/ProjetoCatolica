using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detecta : MonoBehaviour {

    //Referencia ao Player
    public string _playerTag = "Player";

    //Deceta colisão atravez do Trigger
    void OnTriggerEnter(Collider _cole)
    {
        //Detecta apenas o Player
        if (_cole.CompareTag(_playerTag))
        {
            Debug.Log(_cole.gameObject.name);
            //Ativa a animação para abrir a porta
            PortaIncendio._abrirPortaIncendio = true;
        }
    }

    //Deceta colisão atravez do Trigger
    void OnTriggerExit(Collider _cole)
    {

        if (_cole.CompareTag(_playerTag))
        {
            Debug.Log(_cole.gameObject.name);
            //Ativa a animação para fechar a porta
            PortaIncendio._fecharPortaIncendio = true;      
        }
    }
}
