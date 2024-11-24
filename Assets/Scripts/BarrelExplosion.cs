using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelExplosion : MonoBehaviour
{
    [SerializeField] private MeshRenderer _mr;
    [SerializeField] private SpriteRenderer _mrSprite;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            _mr.enabled = false;
            _mrSprite.enabled = true;

            StartCoroutine(DelayDeath());

        }
    }

    IEnumerator DelayDeath()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }
}
