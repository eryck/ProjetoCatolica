using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PontoNave : MonoBehaviour {

    //Varial que indica o local desejado
    public Transform _local;

    // Use this for initialization
    void Start () {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = _local.position;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

}
