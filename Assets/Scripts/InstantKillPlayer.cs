using UnityEngine;

public class InstantKillPlayer : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        var gameManager = FindObjectOfType<GameManager>();
        gameManager.FailedLevel();
    }
}
