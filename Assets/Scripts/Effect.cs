using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    public void setSelfDestruct()
    {
        Animator my_animator = GetComponent<Animator>();
        AnimatorClipInfo[] aci = my_animator.GetCurrentAnimatorClipInfo(0);
        Debug.Log("I'm self destructing! " + aci[0].clip.length);
        //a.clip.length);
        Destroy(gameObject, aci[0].clip.length);
    }//F

}//class
