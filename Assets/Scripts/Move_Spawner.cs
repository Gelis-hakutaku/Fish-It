using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Move_Spawner : MonoBehaviour
{
    private bool goLeft;
    private Vector3 _startPos;
    [SerializeField] private float _limits;

    // Start is called before the first frame update
    void Start()
    {
        goLeft = false;
        _startPos = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        if (goLeft)
        {
            transform.position = new Vector3(transform.position.x - _limits, transform.position.y, transform.position.z) - transform.position;
            if (transform.position.x == _startPos.x - _limits)
                goLeft = true;
        }
        else
        {
            transform.position = new Vector3(transform.position.x + _limits, transform.position.y, transform.position.z) - transform.position;
        }
    }
}
    