using UnityEngine;
using UnityEngine.UI;

public class ShowLevel : MonoBehaviour {

    public Text levelText;

    internal void Show(int a)
    {
        levelText.text = "Level: " + a.ToString();
    }
}
