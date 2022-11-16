using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverState : FallingGameState
{
    public GameOverState(FallingGameStateManager manager) :
        base(manager) {}


    public override void EnterMyState()
    {
        // TODO: Activate results panel
        Debug.Log("Entering Game over");
    }
    

    public override void ExitMyState()
    {
        // TODO: Deactivate game over panel
        Debug.Log("Exiting game over");
    }
}
