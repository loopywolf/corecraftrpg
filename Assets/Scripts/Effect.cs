using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    public Animation a;

    public void selfDestruct()
    {
        Destroy(gameObject, a.clip.length);
        Debug.Log("I die.");
    }//F

}//class
