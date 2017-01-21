using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {


    public static GameManager instance;

    #region Events declaration
    public delegate void GameEvent();
    //eventi base del gioco.
    public event GameEvent OnGameStart, OnCrawling, OnWalking, OnThrowing, OnJumping, OnPushing,
    OnHudHeartBeat, OnLevelEnd,OnPlayLevel, OnLevelBackGround, OnMainMenu, OnTrapStart,OnImpact, OnBonusTaken;
    #endregion

    void Start()
    {
        if (instance == null)
            instance = this;

        if (instance != this)
            Destroy(this.gameObject);

    }

    public void HandleOnBonusTaken() { }

    // Update is called once per frame
    void Update() { }

	public PlayerStates currentPlayerStates;
    

    public void PlayerStates(){
		switch (currentPlayerStates) {
		case global::PlayerStates.Crawling:
			break;
		case global::PlayerStates.Walking:
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