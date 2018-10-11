using UnityEngine.SceneManagement;
using UnityEngine;

public class EndTrig : MonoBehaviour
{

    public GameManager gameManager;

    public void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
         
    }
}
