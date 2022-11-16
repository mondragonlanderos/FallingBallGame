using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingGameState
{
    public enum AppStates
    {
        countingDown,
        playingGame,
        gameOver
    }

    protected FallingGameStateManager GameStateManager;
    private string name;    // name helps state comparison

    public FallingGameState(FallingGameStateManager stateManager, string n)
    {
        GameStateManager = stateManager;
        name = n;
    }

    // Methods to be overwritten by child classes
    public virtual void EnterMyState(){ }
    public virtual void ExitMyState(){ }
    public virtual void StateUpdate(){ }
}
