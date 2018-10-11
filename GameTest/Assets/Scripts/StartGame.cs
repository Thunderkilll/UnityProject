
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

   public void Startgame()
    {
        SceneManager.LoadScene("Level0"); //SceneManager.GetActiveScen().name
    }
}
