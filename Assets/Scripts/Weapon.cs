using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }//Update

    void Shoot()
    {
        //shooting logic
        GameObject bp = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet bScript = bp.GetComponent<bullet>();
        bScript.setSprite(1);
    }//F

}//class

