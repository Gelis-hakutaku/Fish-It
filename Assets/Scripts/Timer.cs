using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TimerManager _timer;
    [SerializeField] private int _duration;
    // Start is called before the first frame update
    void Start()
    {
        _timer.duration = _duration;
        StartCoroutine(CountdownTimer());
    }

    IEnumerator CountdownTimer()
    {
        while (_timer.duration > 0)
        {
            yield return new WaitForSeconds(1f);
            _timer.duration--;
        }


    }
}
