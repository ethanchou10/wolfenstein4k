using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// basic WASD-style movement control
// commented out line demonstrates that transform.Translate instead of charController.Move doesn't have collision detection

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class FPSInput : MonoBehaviour {
	public float speed = 6.0f;
	public float gravity = -9.8f;

	private CharacterController charController;
	
	void Start() {
		charController = GetComponent<CharacterController>();

		// Make the cursor invisible and locked to the center of the screen
		// webgl 360 rotation fix
		// https://discussions.unity.com/t/webgl-causing-rotation-error/204492/2
		Cursor.lockState = CursorLockMode.Locked;
	}
	
	void Update() {
		//transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
		float deltaX = Input.GetAxis("Horizontal") * speed;
		float deltaZ = Input.GetAxis("Vertical") * speed;
		Vector3 movement = new Vector3(deltaX, 0, deltaZ);
		movement = Vector3.ClampMagnitude(movement, speed);

		movement.y = gravity;

		movement *= Time.deltaTime;
		movement = transform.TransformDirection(movement);
		charController.Move(movement);
	}
}
