using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountingDownState : FallingGameState
{
    public CountingDownState(FallingGameStateManager manager) :
        base(manager, "count") {}

    // Overrides parent method to enter the countdown state
    public override void EnterMyState()
    {
        GameStateManager.CountdownCanvas.SetActive(true);
        // TODO: Start timer
    }
    
    // Overrides parent method to exit the countdown state
    public override void ExitMyState()
    {
        GameStateManager.CountdownCanvas.SetActive(false);
    }

    // Updates the countdown timer to begin counting down
    public override void StateUpdate()
    {
        // GameStateManager.UpdateText("Game begins in... " + GameStateManager.CountDownTimer.GetCount().ToString());

        // TODO: Check countdown for 0
    }
}
