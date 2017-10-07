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
	}

	void Update (){
		agent.SetDestination (Destinations[indexDestination].transform.position);
	}

	//loop the destinations
	void OnTriggerEnter(Collider other){
		if(other == Destinations[indexDestination]){
			indexDestination++;
			if (indexDestination == Destinations.Count) {
				indexDestination = 0;
			}
		}
	}
}
