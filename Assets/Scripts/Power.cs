
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power 
{

    Rigidbody rb;
    GameObject gameobject;
    public Power(GameObject gameobject)
    {
        this.gameobject = gameobject;
        rb = gameobject.GetComponent<Rigidbody>();
    }


    public void jump()
    {
       
    }
}
	
// Analysis disable once CheckNamespace
public class JetPack : Power 
{
    GameObject gameObjetcInstance;
	Rigidbody rb;

	int jumpForce;

	public int getJumpForce(){
		return jumpForce;
	}

	public void setJumpForce(int force){
		jumpForce = force;
	}

    public JetPack (GameObject characterBody) : base  (characterBody)
    {
		gameObjetcInstance = characterBody;
		rb = gameObjetcInstance.GetComponent<Rigidbody>();
    }

    public override void SpecialPower(){
		rb.AddForce (new Vector3(0,jumpForce,0));
    }
}


public class SuperSmash : Power 
{
	GameObject gameObjetcInstance;
	Rigidbody rb;

	int jumpForce;

	public int getJumpForce(){
		return jumpForce;
	}

	public void setJumpForce(int force){
		jumpForce = force;
	}

	public SuperSmash (GameObject characterBody) : base  (characterBody)
	{
		gameObjetcInstance = characterBody;
		rb = gameObjetcInstance.GetComponent<Rigidbody>();
	}

	public override void SpecialPower(){
		rb.AddForce (new Vector3(0,jumpForce,0));
	}
}