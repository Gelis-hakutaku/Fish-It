using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo_Behaviour : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private ScoreManager _score;

    private Transform target;
    private int bonusChain;


    private void Start()
    {
        bonusChain = 1;

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

    private void OnTriggerEnter(Collider collision)
    {
        CompareTag("Fish");
            {
                _score.score += 10 * bonusChain;
                bonusChain *= 2;
                Destroy(collision.gameObject);
            }
        Debug.Log(_score.score);
    }
}
