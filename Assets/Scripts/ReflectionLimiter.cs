using UnityEngine;

public class ReflectionLimiter : MonoBehaviour
{
    public Rigidbody rb;
    public GameManager gameManager;
    public int reflections = 5;

    ShowRemainingBounces bounceCounter;

    void Start()
    {
        bounceCounter = FindObjectOfType<ShowRemainingBounces>();

    }

    void Update()
    {
        if (reflections == 0)
        {
            gameManager.FailedLevel();
        }
        if (gameManager.gameHasEnded)
        {
            rb.velocity = Vector3.zero;

        }

        bounceCounter.Show(reflections);
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag != "Ground")
        {
            reflections--;
        }
    }
}
