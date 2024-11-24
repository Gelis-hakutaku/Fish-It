using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Target_Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _lifetime;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private Transform _body;

    // Start is called before the first frame update
    void Start()
    {
        _rb.AddForce(_speed/Random.Range(2, 4), _speed, 0f);

        StartCoroutine(Lifetime());
    }

    void FixedUpdate()
    {
        Vector3 direction = _rb.velocity.normalized;
        if (_body)
            _body.rotation = Quaternion.LookRotation(direction);
    }

    IEnumerator Lifetime()
    {
        yield return new WaitForSeconds(_lifetime);
        Destroy(this.gameObject);
    }
}
