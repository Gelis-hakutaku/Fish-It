using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Score", menuName = "Scriptable Objects/Score", order = 1)]
public class ScoreManager : ScriptableObject
{
    [SerializeField] private int _score;

    public int Score
    {
        get => _score;
        set => _score = value;
    }
}
