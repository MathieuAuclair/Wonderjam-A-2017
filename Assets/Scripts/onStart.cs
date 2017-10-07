<<<<<<< HEAD
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
=======
﻿using System.Collections;
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
>>>>>>> c1f430f648b689f85e765b731a6f783ffcc36a4e
