using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Score", menuName = "Scriptable Objects/Score", order = 1)]
public class ScoreManager : ScriptableObject
{
    [SerializeField] private int _score;
    private int _highscore;

    public int score
    {
        get => _score;
        set => _score = value;
    }

    public int highscore
    {
        get => _highscore;
        set => _highscore = value;
    }
}
