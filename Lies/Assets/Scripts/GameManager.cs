
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public float restartDelay = 1;
     void Update()
    {




    }
    
        
    
    public void GameOver()
    {

        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("you ded.");
            Invoke("Restart", restartDelay);
        }


    }


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
