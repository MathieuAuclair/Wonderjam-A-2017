using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onPlay : MonoBehaviour {
    public Text money;
    MoneyManagement cash;
    // Update is called once per frame
    void Update () {
        Debug.Log("money");
        money.text = "Money : " + cash.money;
	}
}
