
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onStart : MonoBehaviour {
    public Text money;
    private MoneyManagement moneySystem;
	// Use this for initialization
	void Start () {
        money.text = "Money : " + moneySystem.money + "$";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}