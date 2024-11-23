using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TimerManager timer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountdownTimer());
    }

    IEnumerator CountdownTimer()
    {
        while (timer.duration > 0)
        {
            yield return new WaitForSeconds(1f);
            timer.duration--;
            Debug.Log(timer.duration);
        }


    }
}
