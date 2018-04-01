using UnityEngine;

public class ClickForPath : MonoBehaviour
{

    public float forwardForce = 250f;
    public float topSpeed = 750f;
    public Rigidbody rb;
    public int maxClicks = 1;

    internal int clickCount;
    internal bool clicked;


    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                    clicked = true;
            }
        }

        if (clicked && clickCount < maxClicks)
        {
            FollowClick();
        }
    }

    void FollowClick()
    {
        // Face Clicked point in World
        var distance = Vector3.Distance(transform.position, Camera.main.transform.position);

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 rayPoint = ray.GetPoint(distance);
        rayPoint.y = 1.0f;

        transform.LookAt(rayPoint);

        rb.AddForce(transform.forward * forwardForce);
        if (rb.velocity.magnitude > topSpeed)
        {
            rb.velocity = rb.velocity.normalized * topSpeed;
        }

        clickCount++;
        clicked = false;

    }

    internal void StopForAnotherClick()
    {
        rb.velocity = Vector3.zero;
        clicked = false;
        maxClicks += 1;
    }
}
