using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
	
	// Update is called once per frame
	void Update () {
        //we gonna calcultae the distance that our player made
        scoreText.text = player.position.z.ToString("0");


    }
}
