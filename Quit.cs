using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public Action onExitAction; 

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            onExitAction?.Invoke();
        }
    }
}
