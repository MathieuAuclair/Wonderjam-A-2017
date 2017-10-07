using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour
{

    Rigidbody rb;
    GameObject characterGameObject;
    public Power(GameObject characterObject)
    {
        this.characterGameObject = characterObject;
        rb = characterObject.GetComponent<Rigidbody>();
    }


    public void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.AddForce(0, 100, 0);
        }
    }

    public void Attack()
    {
       
    }



    /*heritage copied from the net and adapred*/

    public virtual void SpecialPower()
    {
        //Do stuff
    }
}
public class JetPack : Power 
{
    GameObject gameObjetcInstance;

    public JetPack (GameObject object1) : base  (object1)
    {

    }

    public override void SpecialPower()
    {
        //Do stuff
    }
}
