using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallingGameStateManager : MonoBehaviour
{
    [HideInInspector] public CountingDownState countingDownState; 
    [HideInInspector] public PlayingGameState playingGameState; 
    [HideInInspector] public GameOverState gameOverState;

    private FallingGameState currState;

    // public ApplicationStateManager AppStateManager;
    // public GameStartTimer CountDownTimer;
    // public ScoreKeeper Scorekeeper; 
    
    // TODO: Hook up to app state manager
    // TODO: Add timer
    // TODO: Add ScoreKeeper
    

    private void Awake()
    {
        countingDownState = new CountingDownState(this);
        playingGameState = new PlayingGameState(this);
        gameOverState = new GameOverState(this);
    }

    private void Start()
    {
        EnterState(countingDownState);
    }

    private void Update()
    {
        currState.StateUpdate();
    }
    
    public void EnterState(FallingGameState newState)
    {
        if (currState is null)
        {
            Debug.Log("currstate was null");
            currState = newState;
            currState.EnterMyState();
        }
        else {
            currState.ExitMyState();
            currState = newState;
            currState.EnterMyState();
        }
    }

    
    public FallingGameState GetCurrState()
    {
        return currState;
    }

    
    public void NextState()
    {
        if (currState == countingDownState)
        {
            Debug.Log("Moving from countingDownState to playingGameState");
            EnterState(playingGameState);
        }
        else if (currState == playingGameState)
        {
            Debug.Log("Moving from playingGameState to gameOverState");
            EnterState(gameOverState);
        }
        else if (currState == gameOverState)
        {
            Debug.Log("Moving from gameOverState to countingDownState");
            EnterState(countingDownState);
        }
    }
}