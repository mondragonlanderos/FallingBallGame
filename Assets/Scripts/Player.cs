using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private GameObject player;
    float speed = 8f;
    
    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    public void OnInputA()
    {
        movePlayerLeft();
        checkBounds();
    }

    public void OnInputD()
    {
        movePlayerRight();
        checkBounds();
    }

    public void movePlayerLeft()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    public void movePlayerRight()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

    public void checkBounds()
    {
        Vector2 playerPosScreen = Camera.main.WorldToScreenPoint(transform.position);
        if (playerPosScreen.x > Screen.width - 60.0f)
        {
            transform.position =
                Camera.main.ScreenToWorldPoint(
                    new Vector3(Screen.width - 60.0f,
                                playerPosScreen.y,
                                transform.position.z - Camera.main.transform.position.z));
        }
        else if (playerPosScreen.x < 60.0f)
        {
            transform.position =
                Camera.main.ScreenToWorldPoint(
                    new Vector3(60.0f,
                                playerPosScreen.y,
                                transform.position.z - Camera.main.transform.position.z));
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        //Handle collisions
    }
}
