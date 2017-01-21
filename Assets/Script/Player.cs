using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


	
	
	 float speed =2;

	public int JumpForce =10;
	public  bool IsTouchingPlane = true;
    private int heartsCount;

    public int HeartsCount
    {
        get { return heartsCount; }
        set {if (heartsCount != value)
            {

                switch (heartsCount)
                {
                    case 1:
                        currentPlayerStates = PlayerStates.Walking;
                        OnChangedPlayerStates();
                        break;
                    case 2:
                        currentPlayerStates = PlayerStates.FinalStage;
                        OnChangedPlayerStates();
                        break;
                    default:
                        break;
                }
            }
            heartsCount = value;
        }
    }


    private Vector3 motion = Vector3.zero;
	
	void Start () {

       currentPlayerStates =  PlayerStates.Crawling;
        OnChangedPlayerStates();
		IsTouchingPlane = true;
		
	}
	
	
	void FixedUpdate () {
		
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
        if (other.tag == "Plane" && other.GetComponent<PlatformLeftRight>() != null) {
            transform.SetParent(other.transform);
        }
        if (other.tag == "Heart")
        {
          
            HeartsCount++;
            Destroy(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Plane" && other.GetComponent<PlatformLeftRight>() != null)
        {
            transform.SetParent(null);
        }
    }


    public PlayerStates currentPlayerStates;


    public void OnChangedPlayerStates()
    {
        switch (currentPlayerStates)
        {
            case global::PlayerStates.Crawling:
                JumpForce = 2;
                break;
            case global::PlayerStates.Walking:
                JumpForce = 10;
                break;
            case global::PlayerStates.FinalStage:
                break;
        }
    }
}
public enum PlayerStates
{
    Crawling,
    Walking,
    FinalStage
}


