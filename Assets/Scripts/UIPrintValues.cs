using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIPrintValues : MonoBehaviour
{
    [SerializeField] private TimerManager _time;
    [SerializeField] private ScoreManager _score;
    [SerializeField] private TextMeshProUGUI _timer;
    [SerializeField] private TextMeshProUGUI _scoreToPrint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timer.text = _time.duration.ToString();
        _scoreToPrint.text = _score.score.ToString();
    }
}
