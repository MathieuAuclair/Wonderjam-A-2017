using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Analysis disable once CheckNamespace
public class charcaterController : MonoBehaviour{
	private Power powerUp;
    private Rigidbody rb;
	public float speed;

    // Use this for initialization
    void Start(){
		rb = gameObject.GetComponent<Rigidbody>();
		powerUp = new Power(gameObject);
    }

    // Update is called once per frame
    void Update(){
		float depHorizontal = Input.GetAxis("Horizontal");
		float depVertical = Input.GetAxis("Vertical");
		Vector3 mouvement = new Vector3(depHorizontal, 0, depVertical);

		//transform.position += (mouvement * speed);

    }
}
