using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charcaterController : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    private Power power;
    
    public charcaterController()
    {
        
    }
    // Use this for initialization
    void Start()
    {
        power = new Power(this.gameObject);
        rb = gameObject.GetComponent<Rigidbody>();
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        deplacement();
        power.jump();
    }
    void deplacement()
    {
        float depHorizontal = Input.GetAxis("Horizontal");
        float depVertical = Input.GetAxis("Vertical");
        Vector3 mouvement = new Vector3(depHorizontal, 0, depVertical);

        rb.AddForce(mouvement * speed );

    }
}
