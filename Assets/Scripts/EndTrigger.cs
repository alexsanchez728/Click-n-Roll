using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager = FindObjectOfType<GameManager>();
        gameManager.CompleteLevel();
    }
}
