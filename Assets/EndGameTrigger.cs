using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameTrigger : MonoBehaviour {
	void OnTriggerEnter(Collider coll){
		if (coll.tag == "Player") {
			Application.LoadLevel ("RenderTexture");
		} else {
			Debug.Log (coll.tag);
		}
	}
}
