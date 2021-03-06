﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    public void SetupScene()
    {
        Debug.Log("SetupScene");
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }//F

}//class
