using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;



// Analysis disable once CheckNamespace
using UnityEngine.AI;


public class AddNPC : ScriptableWizard {

	[MenuItem ("MoistyTools/Create a NPC %g")]
	static void CreatePickableObject(){
		ScriptableWizard.DisplayWizard<AddNPC> ("Set object as NPC");
	}

	void OnWizardCreate(){
		if (Selection.activeTransform != null) {
			GameObject SelectedObject = Selection.activeTransform.gameObject;
			if (SelectedObject != null) {
				SelectedObject.AddComponent(typeof(NavMeshAgent));
				SelectedObject.AddComponent(typeof(PathfindingNPC));
				SelectedObject.GetComponent<BoxCollider> ().isTrigger = true;
			}
		} else {
			Debug.Log ("SELECT AN ITEM FIRST!!!");
		}
	}
}
