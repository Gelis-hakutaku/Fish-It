using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private TimerManager _timer;
    [SerializeField] private ScoreManager _scoreManager;
    [SerializeField] private int _duration;
    // Start is called before the first frame update
    void Start()
    {
        _timer.duration = _duration;
        _scoreManager.score = 0;
        StartCoroutine(CountdownTimer());
    }

    IEnumerator CountdownTimer()
    {
        while (_timer.duration > 0)
        {
            yield return new WaitForSeconds(1f);
            _timer.duration--;
        }

        if (_timer.duration == 0)
        {
            yield return new WaitForSecondsRealtime(3);
            SceneManager.LoadScene("Main Menu");
        }


    }
}
