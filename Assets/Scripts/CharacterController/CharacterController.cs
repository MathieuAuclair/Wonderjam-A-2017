using UnityEngine;

// Analysis disable once CheckNamespace
public class CharacterController : MonoBehaviour {
	public float speed = 15.0f;
	public float jump = 200.0f;

	bool isReadyToJump;
    Rigidbody rb;

    void Start() {
		rb = gameObject.GetComponent<Rigidbody> ();
		Cursor.lockState = CursorLockMode.Locked;
		isReadyToJump = true;
	}

	void Update(){
		if (Input.GetKeyDown ("escape")) {
			Cursor.lockState = CursorLockMode.None;
		} 
	}

    void FixedUpdate() {
		float moveY = (isReadyToJump && Input.GetButtonDown("Jump")) ? 100 : 0;
		float moveX = Input.GetAxis ("Horizontal") * speed;
		float moveZ = Input.GetAxis ("Vertical") * speed;

		rb.AddForce(0, moveY, 0);
		transform.Translate (moveX, 0, moveZ);
	}
    
	void OnCollisionEnter(Collision other){
		isReadyToJump = true;
	}

	void OnCollisionExit(Collision other){
		isReadyToJump = false;
	}
}
