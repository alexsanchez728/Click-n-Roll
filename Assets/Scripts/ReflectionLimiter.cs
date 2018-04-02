using UnityEngine;
using UnityEngine.SceneManagement;

public class ReflectionLimiter : MonoBehaviour
{
    public Rigidbody rb;
    public GameManager gameManager;
    public int reflections = 5;

    ShowRemainingBounces bounceCounter;
    ShowLevel levelCounter;

    void Start()
    {
        bounceCounter = FindObjectOfType<ShowRemainingBounces>();
        levelCounter = FindObjectOfType<ShowLevel>();

        levelCounter.Show(SceneManager.GetActiveScene().buildIndex);
    }

    void Update()
    {
        if (reflections <= 0)
        {
            foreach (Collider c in GetComponents<Collider>())
            {
                c.enabled = false;
            }
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
