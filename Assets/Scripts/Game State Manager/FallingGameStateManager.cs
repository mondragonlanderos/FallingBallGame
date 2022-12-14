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
    public GameObject GameplayCanvas;
    public GameObject GameOverCanvas;
    
    // public ApplicationStateManager AppStateManager;
    // public GameStartTimer CountDownTimer;
    public Scoring Scorekeeper;
    // TODO: Add timer

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
    
    public void ObjectCollected()
    {
        Scorekeeper.addScore();
        Scorekeeper.addMaxPoints();
        if (Scorekeeper.maxPoints == 5)
        {
            EnterState(gameOverState);
        }
    }
    
    public void ObjectMissed()
    {
        Scorekeeper.addMaxPoints();
        if (Scorekeeper.maxPoints == 5)
        {
            EnterState(gameOverState);
        }
    }
    
}
