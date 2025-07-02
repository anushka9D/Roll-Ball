using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelLoad : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
