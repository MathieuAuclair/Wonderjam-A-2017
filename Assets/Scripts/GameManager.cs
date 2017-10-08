using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Analysis disable once CheckNamespace
public class GameManager : MonoBehaviour {

	/*HARDCODED STUFF LVL 5000*/

	public int startMoney;
	public int salaireMin;
	public int salaireMax;

	/**/


	GameObject playerGameObject;

	void Awake () {
		GameObject spawnObject = GameObject.Find ("Spawn");
		if(spawnObject != null){
			Vector3 spawn = spawnObject.transform.position;
			playerGameObject = Instantiate(Resources.Load("player"), spawn, Quaternion.identity) as GameObject;
		}
	}

	void Update () {
		
	}

	void EndGame(bool result){
		string output;
		int loss;
		if (result) {
			loss = 0.1 * Random.Range(salaireMin, salaireMax) as int;
			startMoney -= loss;
			output = "Congrat! You've won " + 10 * loss + " but recession cost you " + loss * 11;
		} else {
			startMoney -= loss * 11;
			output = "You've lost the contract and the recession cost you " + loss * 11; 
			/*********************************************************TODO*/
		}
		DontDestroyOnLoad(this);
		Application.LoadLevel ("MainMenu");
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
















public abstract class Objective{
	protected int seconds, objective;

	public Objective(int seconds, int objective){
		this.seconds = seconds;
		this.objective = objective;
	}

	public virtual void TriggerObjective(){
		//virtual void
	}

	public void EnterObjectiveEnd(bool result){
		GameObject.Find ("GameManager").GetComponent<GameManager> ().EndGame(result);
	}
}

public class Task : Objective{
	public override void TriggerObjective(){
		objective -= 1;
		if (objective == 0) {
			EnterObjectiveEnd (true);
		}
	}
}

public class Run : Objective{
	public override void TriggerObjective(){
		
	}
}
