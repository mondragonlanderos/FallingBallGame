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

    public GameObject CountdownCanvas; 
    public GameObject PlayingGameCanvas;
    public GameObject GameOverCanvas;
    
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
    

    
    // TESTING METHOD
    public void NextState()
    {
        if (currState == countingDownState)
        {
            EnterState(playingGameState);
        }
        else if (currState == playingGameState)
        {
            EnterState(gameOverState);
        }
        else if (currState == gameOverState)
        {
            EnterState(countingDownState);
        }
    }
    
    
    // TESTING METHOD
    public void GameOver()
    {
        EnterState(gameOverState);
    }
}
