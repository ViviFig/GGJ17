using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public enum PlayerStates{
		 Nonno,
		 Bambino}
		;
	public PlayerStates currentPlayerStates;

	//public bool IsNonno;
	//public bool IsNipote;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ChangePlayer(){
		switch (currentPlayerStates) {
		case PlayerStates.Nonno:
			break;
		case PlayerStates.Bambino:
			break;
	}
	}
}
