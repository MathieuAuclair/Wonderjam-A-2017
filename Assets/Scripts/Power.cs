
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Analysis disable once CheckNamespace

public class Power{
	public int powerUpForce;
	protected GameObject characterGameObject;
	protected Rigidbody rb;

    public Power(GameObject characterBody){
		characterGameObject = characterBody;
		rb = characterGameObject.GetComponent<Rigidbody> ();
	}

	public virtual void SpecialPower(){
		//override void
	}
}
	
// Analysis disable once CheckNamespace
public class JetPack : Power 
{
    public JetPack (GameObject characterBody) : base  (characterBody){}

    public override void SpecialPower(){
		int jumpForce = powerUpForce * 100;
		rb.AddForce (new Vector3(0,jumpForce,0));
    }
}


// Analysis disable once CheckNamespace
public class SuperSmash : Power
{
    public SuperSmash(GameObject characterBody) : base(characterBody) { }

    public override void SpecialPower()
    {
        //TODO need to add marc-antoine power smash
    }
}


// Analysis disable once CheckNamespace
public class SuperSpeed : Power
{
    public SuperSpeed(GameObject characterBody) : base(characterBody) { }

    public override void SpecialPower()
    {
        //TODO need to add marc-antoine power smash
    }
}