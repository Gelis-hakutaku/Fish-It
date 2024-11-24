using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo_Behaviour : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private ScoreManager _score;
    [SerializeField] private TimerManager _timer;
    [SerializeField] private int bonusChain;

    [SerializeField] private WeaponManager _weapon;
    private float normalFireRate;
    private Transform target;



    private void Start()
    {
        target = FindObjectOfType<Follow_Cursor>().transform;

        normalFireRate = _weapon.fireRate;

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

    /*IEnumerator Blinded()
    {
        Vector3 spawnPos = Camera.main.WorldToScreenPoint(Camera.main.transform.position);
        Instantiate(_uiManager.uiEncre, spawnPos, Quaternion.LookRotation(Camera.main.transform.position));
        yield return new WaitForSeconds(3f);
    }*/

    IEnumerator IncreaseFirerate()
    {
        _weapon.fireRate = 0.2f;
        yield return new WaitForSeconds(5f);
        _weapon.fireRate = normalFireRate;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Fish"))
        {
            _score.score += 10 * bonusChain;
            bonusChain *= 2;
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("RainbowFish"))
        {
            _timer.duration += 10;
            _score.score += 10 * bonusChain;
            bonusChain *= 2;
            Destroy(collision.gameObject);
        }

        /*if (collision.CompareTag("Squid"))
        {
            StartCoroutine(Blinded());
        }*/

        if (collision.CompareTag("PufferFish"))
        {

        }
        Debug.Log(_score.score);

        if (collision.CompareTag("Barrel"))
        {
            StartCoroutine(IncreaseFirerate());
            Destroy(collision.gameObject);
        }
    }
}
