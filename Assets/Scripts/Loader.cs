using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    public GameObject myGameManager;

    // Start is called before the first frame update
    void Awake()
    {
        if (MyGameManager.instance == null)
            Instantiate(myGameManager);
    }//Awake

    // Update is called once per frame
    void Update()
    {
        
    }
}
