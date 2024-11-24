using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UIManager", menuName = "Scriptable Objects/UIManager", order = 1)]

public class UIManager : ScriptableObject
{
    [SerializeField] private GameObject _uiEncre;

public GameObject uiEncre
    {
        get => _uiEncre;
        set => _uiEncre = value;
    }
}
