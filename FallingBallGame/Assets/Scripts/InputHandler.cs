using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputHandler : MonoBehaviour
{
    public UnityEvent onInputLeft;
    public UnityEvent onInputRight;
    public UnityEvent onInputEnter;
    public UnityEvent onInputEsc;

    void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        if (Input.GetKey(KeyCode.A))
        {
            SendMoveEvent(KeyCode.A);
        }

        if (Input.GetKey(KeyCode.D))
        {
            SendMoveEvent(KeyCode.D);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SendMoveEvent(KeyCode.Return);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SendMoveEvent(KeyCode.Escape);
        }
    }
    private void SendMoveEvent(KeyCode keycode)
    {
        switch (keycode)
        {
            case KeyCode.A:
                onInputLeft.Invoke();
                break;
            case KeyCode.D:
                onInputRight.Invoke();
                break;
            case KeyCode.Return:
                onInputEnter.Invoke();
                break;
            case KeyCode.Escape:
                onInputEsc.Invoke();
                break;
        }
    }

}
