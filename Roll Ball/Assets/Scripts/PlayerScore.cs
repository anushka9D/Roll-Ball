using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public Text scoreText;
    public float coinValue;
    public float scoreInLevel;
    public float scoreInLastLevel;

    
    private void Start()
    {
        scoreInLastLevel = PlayerPrefs.GetFloat("ScoreInLevel");
    }
    
    
    // Update is called once per frame
    void Update()
    {
        //scoreText.text = (coinValue).ToString("0");
        scoreInLevel = coinValue + scoreInLastLevel;
        scoreText.text = scoreInLevel.ToString("0");
    }
}
