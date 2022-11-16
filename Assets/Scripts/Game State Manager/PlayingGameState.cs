using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PlayingGameState : FallingGameState
{
    public PlayingGameState(FallingGameStateManager manager) :
        base(manager, "game") {}


    public override void EnterMyState()
    {
        GameStateManager.PlayingGameCanvas.SetActive(true);
        // TODO: Start game timer
    }
    

    public override void ExitMyState()
    {
        GameStateManager.PlayingGameCanvas.SetActive(false);
    }
    
    public override void StateUpdate()
    {
        // ????
    }
}
