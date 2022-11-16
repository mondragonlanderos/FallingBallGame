using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingGameState : FallingGameState
{
    public PlayingGameState(FallingGameStateManager manager) :
        base(manager) {}


    public override void EnterMyState()
    {
        GameStateManager.GameplayCanvas.SetActive(true);
        // TODO: Start game timer
        Debug.Log("Entering playing game");
    }
    

    public override void ExitMyState()
    {
        GameStateManager.GameplayCanvas.SetActive(false);
        Debug.Log("Exiting playing game");
    }
    
    public override void StateUpdate()
    {
        // ????
    }
}
