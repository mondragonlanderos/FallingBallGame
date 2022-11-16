using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountingDownState : FallingGameState
{
    public CountingDownState(FallingGameStateManager manager) :
        base(manager) {}

    // Overrides parent method to enter the countdown state
    public override void EnterMyState()
    {
        // TODO: Activate countdown panel
        // TODO: Start timer
        Debug.Log("Entering counting down");
    }
    
    // Overrides parent method to exit the countdown state
    public override void ExitMyState()
    {
        // TODO: Deactivate countdown panel
        Debug.Log("Exiting counting down");
    }

    // Updates the countdown timer to begin counting down
    public override void StateUpdate()
    {
        // GameStateManager.UpdateText("Game begins in... " + GameStateManager.CountDownTimer.GetCount().ToString());

        // TODO: Check countdown for 0
    }
}
