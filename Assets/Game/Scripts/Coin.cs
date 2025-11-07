using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _price;

    private void OnTriggerEnter(Collider other)
    {
        ScoreCounter scoreCounter = other.GetComponent<ScoreCounter>();

        if(scoreCounter != null)
        {
            scoreCounter.AddScore(_price);
            Destroy(gameObject);
        }

    }
}
