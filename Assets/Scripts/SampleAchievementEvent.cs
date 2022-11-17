using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SampleAchievementEvent : MonoBehaviour
{
    public UnityEvent OnThreeObjectsCollected;
    public UnityEvent OnAllObjectsCollected;
    public UnityEvent OnGameEnd;
    public bool threeObjectsCollected = false;
    public bool allObjectsCollected = false;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitToShowAchievements());
    }
    
    //stand in for waiting for the end of game
    private IEnumerator WaitToShowAchievements()
    {
        yield return new WaitForSeconds(3f);
        if (threeObjectsCollected)
            OnThreeObjectsCollected.Invoke();
        if (allObjectsCollected)
            OnAllObjectsCollected.Invoke();
        OnGameEnd.Invoke();
        print("Unlocked");
    }
}
