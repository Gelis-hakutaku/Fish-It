using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Scriptable Objects/Weapon", order = 1)]

public class WeaponManager : ScriptableObject
{
    [SerializeField] private float _fireRate;

    public float fireRate
    {
        get => _fireRate;
        set => _fireRate = value;
    }
}
