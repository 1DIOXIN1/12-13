using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _price;
    public int Price => _price;
    
    public void Collect()
    {
        Destroy(gameObject);
    }
}
