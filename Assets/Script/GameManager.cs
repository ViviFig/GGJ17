using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public enum PlayerStates{
		 Lev1,
         Lev2,
         Lev3
		 }
		;
	public PlayerStates currentPlayerStates;
    
	
	public void ChangePlayer(){
		switch (currentPlayerStates) {
		case PlayerStates.Lev1:
			break;
		case PlayerStates.Lev2:
			break;
        case PlayerStates.Lev3:
                break;
        }
	}
}
