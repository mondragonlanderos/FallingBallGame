using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverState : FallingGameState
{
    public GameOverState(FallingGameStateManager manager) :
        base(manager) {}


    public override void EnterMyState()
    {
        GameStateManager.GameOverCanvas.SetActive(true);
        Debug.Log("Entering Game over");
    }
    

    public override void ExitMyState()
    {
        GameStateManager.GameOverCanvas.SetActive(false);
        Debug.Log("Exiting game over");
    }
}
