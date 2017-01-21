using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {


    public static GameManager instance;

    #region Events declaration
    public delegate void GameEvent();
    //eventi base del gioco.
    public event GameEvent OnGameStart;
    public event GameEvent OnLevelEnd;
    public event GameEvent OnPlayLevel;
    public event GameEvent OnGameWin;
    // evento che fa partire il gioco/livello

    //eventi per i bonus
    public event GameEvent OnBonusTaken;

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
public enum PlayerStates
{
    Lev1,
    Lev2,
    Lev3
}