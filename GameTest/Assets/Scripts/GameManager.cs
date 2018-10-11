using UnityEngine.SceneManagement; //for the restart 
 
using UnityEngine;

public class GameManager : MonoBehaviour {

    //game manager for all the game
    bool GameEnded = false;
    public float Delay = 1f;
    public GameObject CompleteLvlUI ;
	public GameObject mouvements ;
    public void EndGame()
    {
        if (GameEnded == false)
        {
            GameEnded = true;
            Debug.Log("Game Over");
            //restart
            //methode 1 Restart();
            //methode 2 avec délais we use Invoque
            Invoke("Restart", Delay);

        }
       
      
    }
    void Restart()
    {
		mouvements.SetActive(true);
        SceneManager.LoadScene("Level0"); //SceneManager.GetActiveScen().name
    }
    public void CompleteLevel()
    {
        CompleteLvlUI.SetActive(true);
		mouvements.SetActive(false);
        Debug.Log("end game 2");
    }
}
