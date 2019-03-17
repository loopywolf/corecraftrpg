using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public GameObject deathEffect;  // I don't have one - oh yes I do!

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
        GameObject de = Instantiate(deathEffect, transform.position, Quaternion.identity);
        de.GetComponent<Effect>().setSelfDestruct();
        Destroy(gameObject);
    }//F

}//class
