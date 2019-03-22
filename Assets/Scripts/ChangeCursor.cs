﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCursor : MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Oh no! Steven!");
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }//Start

}//class
