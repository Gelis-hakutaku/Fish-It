using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Timer", menuName = "Scriptable Objects/TimerManager", order = 1)]
public class TimerManager : ScriptableObject
{
    [SerializeField] private int _duration;

    public int duration
    {
        get => _duration;
        set => _duration = value;
    }

}
