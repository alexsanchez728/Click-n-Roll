using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 2f;
    public GameObject completeLevelUI;
    public GameObject FailedLevelUI;

    internal bool gameHasEnded = false;

    public void CompleteLevel()
    {
        gameHasEnded = true;
        completeLevelUI.SetActive(true);
    }

    public void FailedLevel()
    {
        gameHasEnded = true;
        FailedLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
