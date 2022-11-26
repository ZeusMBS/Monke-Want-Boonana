using System;
using UnityEngine;

public class CursorLock : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = !Cursor.visible;
        }
    }
}