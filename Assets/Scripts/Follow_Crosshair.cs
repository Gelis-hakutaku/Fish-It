using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Crosshair : MonoBehaviour
{
    [SerializeField] private Transform target;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
    }
}
