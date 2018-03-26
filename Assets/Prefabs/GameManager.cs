using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
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
            Restart();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
