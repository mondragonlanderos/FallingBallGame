using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingGameState : MonoBehaviour
{
    public enum AppStates
    {
        countingDown,
        playingGame,
        gameOver
    }

    protected FallingGameStateManager GameStateManager;

    public FallingGameState(FallingGameStateManager stateManager)
    {
        GameStateManager = stateManager;
    }

    // Methods to be overwritten by child classes
    public virtual void EnterMyState(){ }
    public virtual void ExitMyState(){ }
    public virtual void StateUpdate(){ }
}
