using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingGameState : FallingGameState
{
    public PlayingGameState(FallingGameStateManager manager) :
        base(manager) {}


    public override void EnterMyState()
    {
        // TODO: Activate game panel
        // TODO: Start game timer
        Debug.Log("Entering playing game");
    }
    

    public override void ExitMyState()
    {
        // TODO: Deactivate game panel
        Debug.Log("Exiting playing game");
    }
    
    public override void StateUpdate()
    {
        // ????
    }
}
