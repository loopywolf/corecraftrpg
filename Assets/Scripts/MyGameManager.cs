using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    public static MyGameManager instance = null;  //only one
    public BoardManager boardScript; //link to BoardManager

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);    //make sure there is only one
        DontDestroyOnLoad(gameObject); //make sure it persists between scenes - this is Game Logic
        boardScript = GetComponent<BoardManager>();
        InitGame();
    }//awake

    void InitGame()
    {
        boardScript.SetupScene();
    }

}//class
