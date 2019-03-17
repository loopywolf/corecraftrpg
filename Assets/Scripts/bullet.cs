using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 40;
    public GameObject hitEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }//Start

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log("bulletHit "+hitInfo.name);
        
        /*GameObject he = Instantiate(hitEffect, transform.position, Quaternion.identity);
        // I want to trigger the bullet to die after the animation
        if(he!=null) {
            Animator a = he.GetComponent<Animator>();
            AnimatorClipInfo[] aci = a.GetCurrentAnimatorClipInfo(0);    
            Debug.Log("hi!" + aci[0].clip.length);
            //a.clip.length);
            Destroy(he, aci[0].clip.length);
        }//if */

        GameObject he = Instantiate(hitEffect, transform.position, Quaternion.identity);
        he.GetComponent<Effect>().setSelfDestruct();

        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy!=null)
        {
            enemy.takeDamage(damage);
        }//if
        Destroy(gameObject);
    }//OnTriggerEnter2D

}//class
