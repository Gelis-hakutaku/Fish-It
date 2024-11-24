using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

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
    private GameObject canvas;

    private Queue<Action> actions = new();


    private void Start()
    {
        
        target = FindObjectOfType<Follow_Cursor>().transform;
        normalFireRate = _weapon.fireRate;

        StartCoroutine(LifeTime());

        Vector3 direction = target.position - transform.position;
        transform.LookAt(target.position);
        rb.velocity = direction.normalized * speed;
    }

    private void Update()
    {
        while (actions.TryDequeue(out Action action))
            action.Invoke();
    }

    IEnumerator LifeTime()
    {
        yield return new WaitForSeconds(5.1f);

        Destroy(this.gameObject);
    }

    IEnumerator Blinded()
    {
        canvas = EncreClass.Encre;
        canvas.SetActive(true);

        yield return null;
    }

    IEnumerator IncreaseFirerate()
    {
 
        yield return new WaitForSeconds(5);
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

        if (collision.CompareTag("Squid"))
        {
            StartCoroutine(Blinded());
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("PufferFish"))
        {

        }

        if (collision.CompareTag("Barrel"))
        {
            _score.score += 5;
            //_weapon.fireRate = 0.2f;
            //StartCoroutine(IncreaseFirerate());
        }
    }
}
