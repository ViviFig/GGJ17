using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


	public bool CanMove;
	public int Gravity =9;
	public float speed ;

	public int JumpForce =10;
	public  bool IsTouchingPlane = true;
//	public bool HandIsBusy;

	private Vector3 motion = Vector3.zero;
	// Use this for initialization
	void Start () {
		//CanMove = true;
		JumpForce = 10;
		IsTouchingPlane = true;
		//HandIsBusy = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (CanMove)
		PlayerMovement();
	
	}

	public void PlayerMovement(){

			//float speed = 4.0f;
			
			float translationX = Input.GetAxisRaw("Horizontal") * speed;
			
			float pos = transform.position.x;
			translationX *= Time.deltaTime;
			transform.Translate(translationX, 0, 0);

		if(transform.position.x >=12)
			transform.position = new Vector3 (12, transform.position.y, transform.position.z);

		if(transform.position.x <=-12)
			transform.position = new Vector3 (-12, transform.position.y, transform.position.z);
		

			
		if (Input.GetKeyUp (KeyCode.Space) && IsTouchingPlane == true) {
			IsTouchingPlane = false;
			GetComponent<Rigidbody> ().AddForce (0, JumpForce, 0, ForceMode.Impulse);
		}

		if (Input.GetKeyUp (KeyCode.LeftShift) && IsTouchingPlane == true) {
			IsTouchingPlane = false;

		}


		} 
		
	

	}
	

