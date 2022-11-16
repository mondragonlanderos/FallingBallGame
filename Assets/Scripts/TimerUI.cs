using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI
{
    public Text CountdownText;
    public Text TimerText;
    
    public void ShowCountdown(string count)
    {
        CountdownText.text = count;
    }

    public void ShowTimer(string minutes, string seconds)
    {
        TimerText.text = minutes + ":" + seconds;
    }
}
