using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


	public bool CanMove;
	
	public float speed ;

	public int JumpForce =10;
	public  bool IsTouchingPlane = true;


	private Vector3 motion = Vector3.zero;
	
	void Start () {
		
		JumpForce = 10;
		IsTouchingPlane = true;
		
	}
	
	
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

		//if (Input.GetKeyUp (KeyCode.LeftShift) && IsTouchingPlane == true) {
		//	IsTouchingPlane = false;

		//}


		}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Plane")
        {
            IsTouchingPlane = true;
        }
    }

}
	

