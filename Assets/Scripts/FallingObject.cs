using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                Debug.Log("collided with player");
                Destroy(gameObject);
                //Game.Instance.ItemGrabbed();
            }
            if (collision.gameObject.CompareTag("BottomWall"))
            {
                Debug.Log("collided with bottom wall");
                Destroy(gameObject);
                //Game.Instance.ItemBreak();
            }
        }
}
