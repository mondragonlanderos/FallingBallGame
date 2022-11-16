using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievements : MonoBehaviour
{
    private AchievementUIBehavior achievementUIBehavior;
    private bool hasMoved = false;
    private bool gotThreeObjects = false;
    private bool gotAllObjects = false;
    
    // Start is called before the first frame update
    void Start()
    {
        achievementUIBehavior = GetComponent<AchievementUIBehavior>();
        StartCoroutine(WaitToShowAchievements());
    }

    public void UnlockAchievements()
    {
        achievementUIBehavior.ChangeCheckTo(1, CheckAllObjectsAchievement());
        achievementUIBehavior.ChangeCheckTo(2, CheckThreeObjectsAchievement());
        achievementUIBehavior.ChangeCheckTo(3, CheckNoMovementAchievement());
    }

    //Will be invoked with InputHandler events. When Player moves, hasMoved gets set to true
    public void CheckForMovement()
    {
        hasMoved = true;
    }

    //if this method gets invoked via an event, its variable gets set to true instead of false
    public void CheckForThreeObjects()
    {
        gotThreeObjects = true;
    }

    public void CheckForAllObjects()
    {
        gotAllObjects = true;
    }
    
    //if player has not moved, returns true to show achievement completed
    private bool CheckNoMovementAchievement()
    {
        return hasMoved == false;
    }
    
    //if player got all three objects, returns true to show achievement completed
    private bool CheckThreeObjectsAchievement()
    {
        return gotThreeObjects == true;
    }
    
    //if player got all objects, returns true to show achievement completed
    private bool CheckAllObjectsAchievement()
    {
        return gotAllObjects == true;
    }

    //stand in for waiting for the end of game
    private IEnumerator WaitToShowAchievements()
    {
        yield return new WaitForSeconds(3f);
        UnlockAchievements();
        print("Unlocked");
    }
}
