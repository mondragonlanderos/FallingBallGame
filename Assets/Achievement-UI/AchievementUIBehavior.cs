using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class AchievementUIBehavior : MonoBehaviour
{
    public GameObject achievementCheck1;
    public GameObject achievementCheck2;
    public GameObject achievementCheck3;

    //Demonstration booleans that can be edited in the editor (set to false for No Check, set to true for Check✅)
    public bool isAchievement1Unlocked;
    public bool isAchievement2Unlocked;
    public bool isAchievement3Unlocked;
    
    // Start is called before the first frame update
    void Start()
    {
        updateChecks();
    }

    //Call this in your Achievement script to turn on a check to signify the achievement has been unlocked.
    public void ShowCheckOn(int num)
    {
        switch(num)
        {
            case 1: 
                achievementCheck1.SetActive(true);
                break;
            case 2:
                achievementCheck2.SetActive(true);
                break;
            case 3:
                achievementCheck3.SetActive(true);
                break;
        }
    }

    //Call this to change the checks for this screen
    private void updateChecks()
    {
        achievementCheck1.SetActive(isAchievement1Unlocked);
        achievementCheck2.SetActive(isAchievement2Unlocked);
        achievementCheck3.SetActive(isAchievement3Unlocked);
    }
}
