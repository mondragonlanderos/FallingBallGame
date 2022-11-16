using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverState : FallingGameState
{
    public GameOverState(FallingGameStateManager manager) :
        base(manager, "over") {}


    public override void EnterMyState()
    {
        GameStateManager.GameOverCanvas.SetActive(true);
    }
    

    public override void ExitMyState()
    {
        GameStateManager.GameOverCanvas.SetActive(false);
    }
}
