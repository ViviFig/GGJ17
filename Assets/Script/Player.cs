using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


    Animator animator;
    //public MeshFilter[] MeshesLetter;

    public float speed = 10;

    public int JumpForce = 10;
    public bool IsTouchingPlane = true;
    private int heartsCount;

    public int HeartsCount
    {
        get { return heartsCount; }
        set { if (heartsCount != value)
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

    void Start() {
        animator = GetComponentInChildren<Animator>();
        currentPlayerStates = PlayerStates.Crawling;
        OnChangedPlayerStates();
        IsTouchingPlane = true;

    }


    void FixedUpdate() {

        PlayerMovement();

    }

    public void PlayerMovement() {



        float translationZ = Input.GetAxisRaw("Horizontal") * speed;

        float pos = transform.position.z;
        translationZ *= Time.deltaTime;
        transform.Translate(0, 0, translationZ);
        //if (Input.GetKeyDown (KeyCode.D)) {
        //    transform.Translate(Vector3.forward * Time.deltaTime);
        //}


        if (Input.GetKeyUp(KeyCode.Space) && IsTouchingPlane == true) {
            animator.SetTrigger("Jumping");
            IsTouchingPlane = false;
            GetComponent<Rigidbody>().AddForce(0, JumpForce, 0, ForceMode.Impulse);
        }


    }

    public void JumpTime() {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Plane")
        {
            IsTouchingPlane = true;
        }
        if (other.GetComponent<PlatformLeftRight>() != null) {
            transform.SetParent(other.transform);
        }
        if (other.GetComponent<Heart>() !=null)
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


