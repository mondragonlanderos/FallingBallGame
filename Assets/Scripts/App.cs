using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{
    public enum ApplicationStates
    {
        MainMenu,
        Playing,
        Exit
    };

    //private FallingMinigame fallingMinigame;

    private void Awake()
    {
        // set instance of falling minigame and maybe achievements
        // fallingMinigame = 
    }

    public void PlayButtonAction()
    {
        // enter falling ball game
    }

    public void QuitButtonAction()
    {
        //quit application
        Application.Quit();
        
    }

    /*
    public void OnStateEnter()
    {
        switch (ApplicationStates)
        {
            case ApplicationStates.MainMenu:
                break;
            case ApplicationStates.Playing:
                break;
            case ApplicationStates.Exit:
        }
    }

    public void OnStateExit()
    {
        
    }

    public void UpdateState()
    {
        
    }

    */
}
