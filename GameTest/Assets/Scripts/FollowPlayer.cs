using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    //this function is for the camera to follow the player

    //variables globales 

    public Transform player ;
    public Vector3 offset=new Vector3(0,1,-3);
	// Update is called once per frame
	void Update () {
        //  Debug.Log("player actual position :"+player.position); 
        //transform avec t miniscule ta3tina el transformation mta3 el objet actuel 
        transform.position = player.position +offset;
	}
}
