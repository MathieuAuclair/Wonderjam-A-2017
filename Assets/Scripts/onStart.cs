using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onStart : MonoBehaviour {
    public Text money;
    private MoneyManagement moneySystem;
	// Use this for initialization
	void Awake () {
        moneySystem = new MoneyManagement();
        moneySystem.money = 5000;
	}
    void Update()
    {
        money.text = "Money : " + moneySystem.money + "$"; 
    }

    public void lossMoney(int loss)
    {
        moneySystem.moneyLoss(loss);
    }

    public void gainMoney(int gain)
    {
        moneySystem.moneyGain(gain);
    }
}
