using UnityEngine;

public class GameEndTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.tag == "Player")
        {
            FindObjectOfType<GameManager>().LevelComplete();
            FindObjectOfType<PlayerMovement>().enabled = false;
            PlayerPrefs.SetFloat("ScoreInLevel", FindObjectOfType<PlayerScore>().scoreInLevel);
        }
    }
}
