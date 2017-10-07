using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
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
=======
public class charcaterController : MonoBehaviour
{
    public float speed = 10.0F;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);
>>>>>>> 67c9cbe8152f53eed35dda65bb10ee20fe0a02f2

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;
    }
}
