using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// Analysis disable once CheckNamespace
public class PathfindingNPC : MonoBehaviour {
	public GameObject Destinations;

	private NavMeshAgent agent;
	private int indexDestination;

	void Start (){
		indexDestination = 0;
		agent = GetComponent<NavMeshAgent>();
		agent.SetDestination (Destinations.transform.GetChild(0).position);
	}

	void Update (){
		if (agent.remainingDistance < 5) {
			indexDestination = Random.Range(0,Destinations.transform.childCount);
			agent.SetDestination (Destinations.transform.GetChild(indexDestination).position);
		} 
	}
}
