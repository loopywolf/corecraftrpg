using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    public float moveSpeed;
    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}//Start
	
	// Update is called once per frame
	void Update () {
		if( Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f )
        {
            //transform.Translate(new Vector3( Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime,
            //0f, 0f ));
            rb2d.velocity = new Vector2( Input.GetAxisRaw("Horizontal") * moveSpeed, rb2d.velocity.y );
        }//if
        if( Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f )
        {
            //transform.Translate(new Vector3( 0f,
            //  Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f ));
            rb2d.velocity = new Vector2( rb2d.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed );
        }//if

        if(Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
        {
            rb2d.velocity = new Vector2(0f, rb2d.velocity.y);
        }
        if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x,0f);
        }

    }//Update

}//class
