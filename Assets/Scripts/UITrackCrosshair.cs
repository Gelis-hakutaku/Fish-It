using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITrackCrosshair : MonoBehaviour
{
    [SerializeField] private Transform _crosshair;
    private Vector3 _crosshairPos;

    // Update is called once per frame
    void Update()
    {
        _crosshairPos = new Vector3 (_crosshair.position.x, _crosshair.position.y, _crosshair.position.z);
        _crosshairPos = Camera.main.WorldToScreenPoint(_crosshairPos);

        transform.position = _crosshairPos;
    }
}
