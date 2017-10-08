using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
    MoneyManagement moneyManager;
	// Use this for initialization
	void Start () {
        moneyManager = gameObject.GetComponent<MoneyManagement>();
        Debug.Log (moneyManager.CheckEndGame(100001));
    }

    // Update is called once per frame
    void Update () {
		
	}
}
