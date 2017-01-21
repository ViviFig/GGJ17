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

			
			
			float translationX = Input.GetAxisRaw("Horizontal") * speed;
			
			float pos = transform.position.x;
			translationX *= Time.deltaTime;
			transform.Translate(translationX, 0, 0);
		

			
		if (Input.GetKeyUp (KeyCode.Space) && IsTouchingPlane == true) {
			IsTouchingPlane = false;
			GetComponent<Rigidbody> ().AddForce (0, JumpForce, 0, ForceMode.Impulse);
		}


		}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Plane")
        {
            IsTouchingPlane = true;
        }
    }

}
	

