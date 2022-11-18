using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerScore;
    public float maxPoints;

    public string letterScore;
    public string finalScore;
    
    //reference to UI 

    public void addScore()
    {
        playerScore++;
        Debug.Log("Current score: " + playerScore);
        //score UI update Score (player Score) 
    }

    public void addMaxPoints()
    {
        maxPoints++;
        Debug.Log("Current total: " + maxPoints);
    }

    public string calculateResult()
    {
        if (playerScore / maxPoints >= 0.9f)
        {
            letterScore = "A";
        }
        else if (playerScore / maxPoints >= 0.8f)
        {
            letterScore = "B";
        }
        else if (playerScore / maxPoints >= 0.7f)
        {
            letterScore = "C";
        }
        else if (playerScore / maxPoints >= 0.6f)
        {
            letterScore = "D";
        }
        else if (playerScore / maxPoints >= 0.5f)
        {
            letterScore = "F";
        }
        
        return letterScore;
    }

    public string getFinalScore()
    {
        finalScore = playerScore + "/" + maxPoints;
        return finalScore;
    }
    
}
