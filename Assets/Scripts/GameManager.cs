using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Analysis disable once CheckNamespace
public class GameManager : MonoBehaviour {

	private GameObject playerGameObject;

	void Awake () {
		Vector3 spawn = GameObject.Find ("Spawn").transform.position;
		playerGameObject = Instantiate(Resources.Load("player"), spawn, Quaternion.identity) as GameObject;
	}

	void Update () {
		
	}

	 Power GenerateRandomPower(){
		switch(Random.Range (0, 3)){
			case 0:
			return new SuperSmash(playerGameObject);
			case 1:
			return new JetPack(playerGameObject);
			case 2:
			return new SuperSpeed(playerGameObject);
			default:
			return null;
		}
	}
}
