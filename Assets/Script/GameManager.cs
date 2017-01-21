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
  
	public PlayerStates currentPlayerStates;



    void Start()
    {
        if (instance == null)
            instance = this;

        if (instance != this)
            Destroy(this.gameObject);

    }

    public void HandleOnBonusTaken() { }

    // Update is called once per frame
    void Update () {
	
	}
    /// <summary>
    /// Gestisce tutte le modifiche alle variabili in base allo Fase del Player
    /// </summary>
	public void OnHeatrhTaken(){
		switch (currentPlayerStates) {
		case PlayerStates.Phase1:
			break;
		case PlayerStates.Phase2:
			break;
        case PlayerStates.Phase3:
            break;

	}
	}
}
public enum PlayerStates
{
    Phase1,
    Phase2,
    Phase3
}
      ;
