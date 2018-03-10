using UnityEngine;

public class GiveBounce : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        var clickForPath = FindObjectOfType<ClickForPath>();

        clickForPath.StopForAnotherClick();
    }
}
