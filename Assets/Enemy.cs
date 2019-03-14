using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public GameObject deathEffect;  // I don't have one =(

    public void takeDamage(int damage)
    {
        health -= damage;
        if (health < 0)
        {
            Die();
        }
    }//F
    
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }//F

}//class
