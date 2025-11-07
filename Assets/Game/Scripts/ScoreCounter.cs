using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    private int _score = 0;
    public int Score => _score;

    public void AddScore(int score)
    {
        _score = Mathf.Abs(score);

        _score += score;
    }
}
