using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Analysis disable once CheckNamespace
public class CharcaterController : MonoBehaviour
{
    public float speed = 10.0F;
    public Rigidbody rb;
    private Power power;


    Dictionary<string, Type> LePetitRobert;

    void Start(){
        //TODO check to set a random PowerUP
        LePetitRobert = new Dictionary<string, Type>();
        LePetitRobert.Add("SuperSmash", typeof(SuperSmash));
        LePetitRobert.Add("JetPack", typeof(JetPack));
        LePetitRobert.Add("SuperSpeed", typeof(SuperSpeed));
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    void Update()
    {
        power = new Power(this.gameObject);
        rb = gameObject.GetComponent<Rigidbody>();
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        
		translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;
    }
    
}
