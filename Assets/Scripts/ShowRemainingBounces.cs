using UnityEngine;
using UnityEngine.UI;

public class ShowRemainingBounces : MonoBehaviour {

    public Text bounceText;

    internal void Show(int a)
    {
        bounceText.text = "Bounces: " + a.ToString();
    }
}
