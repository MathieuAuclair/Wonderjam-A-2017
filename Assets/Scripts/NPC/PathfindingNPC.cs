using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

// Analysis disable once CheckNamespace
public class PathfindingNPC : MonoBehaviour {
	public List<GameObject> Destinations;

	private NavMeshAgent agent;
	private int indexDestination;

	void Start (){
		indexDestination = 0;
		agent = GetComponent<NavMeshAgent>();
		agent.SetDestination (Destinations[0].transform.position);
	}

	void Update (){
		if (agent.remainingDistance < 1) {
			indexDestination++;
			if (indexDestination == Destinations.Count) {
				indexDestination = 0;
			}
			agent.SetDestination (Destinations[indexDestination].transform.position);
		} 
	}
}
