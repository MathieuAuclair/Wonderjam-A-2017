using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// Analysis disable once CheckNamespace
public class PathfindingNPC : MonoBehaviour {
	public GameObject Destinations;

	NavMeshAgent agent;
	int indexDestination;

	void Start (){
		indexDestination = 0;
		agent = GetComponent<NavMeshAgent>();
		agent.SetDestination (Destinations.transform.GetChild(0).position);
	}

	void Update (){
		if (agent.remainingDistance < 5) {
			indexDestination++;
			if (indexDestination >= Destinations.transform.childCount) {
				indexDestination = 0;
			}
			agent.SetDestination (Destinations.transform.GetChild(indexDestination).position);
		} 
	}
}
