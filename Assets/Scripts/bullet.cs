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
        GameObject he = Instantiate(hitEffect, transform.position, Quaternion.identity);
        /* if(he!=null)
        {
            Animation a = he.GetComponent<Animation>();
            Destroy(he, a.clip.length);
            Debug.Log("should die after animation");
        }//if */
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy!=null)
        {
            enemy.takeDamage(damage);
        }//if
        Destroy(gameObject);
    }//OnTriggerEnter2D

}//class
