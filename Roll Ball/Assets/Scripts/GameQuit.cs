using UnityEngine;
using UnityEngine.UI;

public class GameQuit : MonoBehaviour
{
    public Text yourScore;


    private void Start()
    {
        yourScore.text = PlayerPrefs.GetFloat("ScoreInLevel").ToString("0");
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
