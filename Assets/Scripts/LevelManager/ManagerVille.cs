using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Analysis disable once CheckNamespace
public class ManagerVille : MonoBehaviour {

	GameObject playerGameObject;

	void Start(){
		playerGameObject = Instantiate (Resources.Load("Player"), transform.position, Quaternion.identity) as GameObject;
	}

}
