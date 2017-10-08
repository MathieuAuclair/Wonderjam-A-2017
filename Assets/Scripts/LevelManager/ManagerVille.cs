using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Analysis disable once CheckNamespace
public class ManagerVille : MonoBehaviour {

	GameObject playerGameObject;

	void Start(){
		Quaternion rotation = Quaternion.EulerAngles(new Vector3(-90,0,0));
		playerGameObject = Instantiate (Resources.Load("Player"), transform.position, rotation) as GameObject;
	}

}
