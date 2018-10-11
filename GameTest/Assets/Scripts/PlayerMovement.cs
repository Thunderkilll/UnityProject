
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    //paramétres Golbales

    public Rigidbody rb;
    public float pushforce = 2000f ;
    public float sideforce = 500f;
    public Transform player;
   
    public Vector3 offset = new Vector3(0,2,0);
    // Use this for initialization
    //void Start () {
    //runing config starting configuration + wa9tilli tit7al el lo3ba

    //   Debug.Log("*****Test 1 running the game*****");
    //undo gravity 
    //rb.useGravity = false; 
    //adding a force push to the cube 
    //rb.AddForce(0,200,500);

    //	}

    // Update is called once per frame
    void FixedUpdate () {
        //we use deltaTime bech yraka7 el image frame bech yibda even
        rb.AddForce(0, 0, pushforce * Time.deltaTime); //add a force of push force  on the z- axis
        //player movements 

        if(Input.GetKey("d"))
        {
            rb.AddForce(sideforce * Time.deltaTime, 0 , 0, ForceMode.VelocityChange);


        }
        if (Input.GetKey("q"))
        {
            rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);


        }
        if (rb.position.y < -1f )
         {

            FindObjectOfType<GameManager>().EndGame();
        }


    }
}
