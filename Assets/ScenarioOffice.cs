using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioOffice : MonoBehaviour {

    GameObject Player;

    void Awake(){
        Player = Instantiate(Resources.Load("Player"), transform.position, Quaternion.identity) as GameObject;
    }

    public void EndRound(){
        DontDestroyOnLoad(this);
    }
}
