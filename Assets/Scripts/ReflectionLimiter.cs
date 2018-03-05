using UnityEngine;

public class ReflectionLimiter : MonoBehaviour
{
    public Rigidbody rb;
    public GameManager gameManager;
    public int maxReflections = 5;

    int relfections = 0;

    void Update()
    {
        if (relfections == maxReflections)
        {
            rb.velocity = Vector3.zero;
            gameManager.FailedLevel();
        }

    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag != "Ground")
        {
            relfections++;
        }
    }
}
