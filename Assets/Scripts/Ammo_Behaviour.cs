using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo_Behaviour : MonoBehaviour
{
    [SerializeField] private float speed;
    private Transform target;
    [SerializeField] private Rigidbody rb;

    private void Start()
    {
        target = FindObjectOfType<Follow_Cursor>().transform;

        StartCoroutine(LifeTime());

        Vector3 direction = target.position - transform.position;
        transform.LookAt(target.position);
        rb.velocity = direction.normalized * speed;
    }

    IEnumerator LifeTime()
    {
        yield return new WaitForSeconds(3f);

        Destroy(this.gameObject);
    }
}
