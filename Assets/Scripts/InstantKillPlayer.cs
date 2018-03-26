using UnityEngine;

public class InstantKillPlayer : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter(Collider collider)
    {
        gameManager.FailedLevel();
    }
}
