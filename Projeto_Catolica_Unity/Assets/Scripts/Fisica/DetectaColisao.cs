using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectaColisao : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Detector de Colisão
    void OnCollisionEnter(Collision _col)
    {
        //Retorna quem colide
        Debug.Log("Colidindo com: " + _col.gameObject.name);
        
    }

    //Verifica quem sai da colisão
    void OnCollisionExit(Collision _col)
    {
        //Retorna quem sai da colisão
        Debug.Log("Saiu da Colisão: " + _col.gameObject.name);

    }

    //Verifica o que está colidindo 
    void OnCollisionStay(Collision _col)
    {
        //Retorna quem sai da colisão
        Debug.Log("Está Colidindo: " + _col.gameObject.name);

    }
}
