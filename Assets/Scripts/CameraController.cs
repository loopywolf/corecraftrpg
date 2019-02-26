using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject followTarget;
    private Vector3 targetPosition;
    public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}//Start
	
	// Update is called once per frame
	void Update () {
        targetPosition = new Vector3(
            followTarget.transform.position.x,
            //Mathf.RoundToInt(followTarget.transform.position.x), //attempt at fix - didn't work 2019-02-18
            followTarget.transform.position.y,
            //Mathf.RoundToInt(followTarget.transform.position.y),
            transform.position.z );
            //Mathf.RoundToInt(transform.position.z));
        transform.position = Vector3.Lerp(
            transform.position, 
            targetPosition, 
            moveSpeed * Time.deltaTime);
	}//Update
}
