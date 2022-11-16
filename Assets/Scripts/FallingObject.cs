using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FallingObject : MonoBehaviour
{
    public UnityEvent ObjectCollected;
    public UnityEvent ObjectMissed;
    
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("collided with player");
            Destroy(gameObject);
            ObjectCollected.Invoke();
            //ItemPool.Return(gameObject);
        }

        if (collision.gameObject.CompareTag("BottomWall"))
        {
            Debug.Log("collided with bottom wall");
            Destroy(gameObject);
            ObjectMissed.Invoke();
            //ItemPool.Return(gameObject);
        }


    }
}
