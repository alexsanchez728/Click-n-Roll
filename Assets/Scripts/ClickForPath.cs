using UnityEngine;

public class ClickForPath : MonoBehaviour
{

    public float forwardForce = 250f;
    public Rigidbody rb;
    public int maxClicks = 1;

    int clickCount;
    bool clicked;


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

        clickCount++;
        clicked = false;

    }
}
