using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.AddScore(1);

            Debug.Log("Coin collected! Score: " + GameManager.Instance.score);

            Destroy(gameObject);
        }
    }
}