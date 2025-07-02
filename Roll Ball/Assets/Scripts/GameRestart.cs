using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestart : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
}
