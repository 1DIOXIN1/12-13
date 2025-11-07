using UnityEngine;

public class Game : MonoBehaviour
{
    private const string WIN_MESSAGE = "Вы победили!";
    private const string LOOSE_MESSAGE = "Вы проиграли!";
    private const string TIMER_MESSAGE = "Прошедшее время";

    [SerializeField] private float _timeBeforeLose;
    [SerializeField] private float _scoreToWin;
    [SerializeField] private ScoreCounter _scoreCounter;

    private float _timer = 0f;

    private bool _gameOver = false;

    private void Update()
    {
        if (_gameOver)
            return;

        _timer += Time.deltaTime;
        Debug.Log(TIMER_MESSAGE + _timer.ToString("0.00"));

        if (_timer > _timeBeforeLose)
            LooseGame();

        if (_scoreCounter.Score >= _scoreToWin)
            WinGame();
    }

    public void LooseGame()
    {
        Debug.Log(LOOSE_MESSAGE);
        _gameOver = true;
        Time.timeScale = 0;
    }
    
    public void WinGame()
    {
        Debug.Log(WIN_MESSAGE);
        _gameOver = true;
        Time.timeScale = 0;
    }
}
