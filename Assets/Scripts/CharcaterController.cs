using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Analysis disable once CheckNamespace
public class CharcaterController : MonoBehaviour
{
    public float speed = 10.0F;
    public Rigidbody rb;
    private Power power;

    void Start(){
		//TODO check to set a random PowerUP
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
