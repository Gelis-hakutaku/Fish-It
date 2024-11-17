using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Follow_Cursor : MonoBehaviour
{
    private Vector3 _cursorPos;
    
    private void FixedUpdate()
    { 
        float Distance = transform.position.z - Camera.main.transform.position.z;
        _cursorPos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, Distance);
        _cursorPos = Camera.main.ScreenToWorldPoint(_cursorPos);

        Vector3 followXYOnly = new Vector3 (_cursorPos.x, _cursorPos.y, transform.position.z);
        transform.position = followXYOnly; 
    }
}
