using System.Collections;
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
        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.AddForce(0, 100, 0);
        }
    }
}
