 
using UnityEngine;

public class playerCollision : MonoBehaviour {

    public PlayerMovement mvt;
  
        void OnCollisionEnter(Collision colInfo)
    {
        if(colInfo.collider.tag == "Obsticle")
        {
           // Debug.Log("we hit the : " + colInfo.collider.name);
            mvt.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        

    }
}
