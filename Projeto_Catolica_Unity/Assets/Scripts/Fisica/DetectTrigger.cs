using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectTrigger : MonoBehaviour
{

    //Referencia ao Player
    public string _playerTag = "Player";

    //Deceta colisão atravez do Trigger
    void OnTriggerEnter(Collider _col)
    {
        //Detecta apenas o Player
        if (_col.CompareTag(_playerTag))
        {
            //Ativa a animação para abrir a porta
            Porta_Elevador._abrirPortaElevador = true;
        }

    }

    //Deceta colisão atravez do Trigger
    void OnTriggerExit(Collider _col)
    {
        if (_col.CompareTag(_playerTag))
        {
            //Ativa a animação para fechar a porta
            Porta_Elevador._fecharPortaElevador = true;
        }

    }
}
