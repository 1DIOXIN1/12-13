using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField]private ScoreCounter _scoreCounter;

    private void OnTriggerEnter(Collider other)
    {
        Coin coin = other.GetComponent<Coin>();

        if(coin != null)
        {
            _scoreCounter.AddScore(coin.Price);
            coin.Collect();
        }

    }
}
