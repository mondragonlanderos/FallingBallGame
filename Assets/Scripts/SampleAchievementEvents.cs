using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SampleAchievementEvents : MonoBehaviour
{
    public UnityEvent OnThreeObjectsCollected;
    public UnityEvent OnAllObjectsCollected;
    public bool threeObjectsCollected = false;
    public bool allObjectsCollected = false;
    
    // Start is called before the first frame update
    void Start()
    {
        if (threeObjectsCollected == true)
            OnThreeObjectsCollected.Invoke();

        if (allObjectsCollected == true)
            OnAllObjectsCollected.Invoke();
    }
    
    
}
