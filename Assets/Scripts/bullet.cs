using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 40;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }//Start

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log("bulletHit "+hitInfo.name);
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy!=null)
        {
            enemy.takeDamage(damage);
        }//if
        Destroy(gameObject);
    }//OnTriggerEnter2D

}//class
