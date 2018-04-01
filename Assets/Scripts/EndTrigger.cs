using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;
    public GameObject toDeactivate;

    void OnTriggerEnter()
    {
        if (!gameManager.FailedLevelUI.activeSelf)
        {
        toDeactivate.SetActive(false);
        gameManager.CompleteLevel();
        }
    }
}
