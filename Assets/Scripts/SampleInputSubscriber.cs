using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleInputSubscriber : MonoBehaviour
{
    public SoundManager soundManager;
    public void OnInputA()
    {
        Debug.Log("A was pressed. We should move left or something");
        soundManager.PlayButtonHoveredSound();
    }
    
    public void OnInputD()
    {
        Debug.Log("D was pressed. We should move right or something");
        soundManager.PlayButtonClickedSound();
    }
    
    public void OnInputEnter()
    {
        Debug.Log("Enter was pressed. Something should be selected");
        soundManager.PlayGameMusic();
    }
    
    public void OnInputEsc()
    {
        Debug.Log("Escape was pressed. We should quit out of the game");
        soundManager.PlayMenuMusic();
    }
}
