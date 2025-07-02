using UnityEngine;
using UnityEngine.UI;

public class CoinValueAdd : MonoBehaviour
{
    public GameObject scoreText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scoreText.GetComponent<PlayerScore>().coinValue += 1;
            Destroy(gameObject);
        }
    }
}
