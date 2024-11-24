using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrelmovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _lifetime;
    [SerializeField] private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
            _rb.AddForce(_speed, 0f, 0f);

            StartCoroutine(Lifetime());
    }

    IEnumerator Lifetime()
    {
        yield return new WaitForSeconds(_lifetime);
        Destroy(this.gameObject);
    }
}
