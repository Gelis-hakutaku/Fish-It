using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Fish : MonoBehaviour
{
    [SerializeField] private GameObject[] fish;
    [SerializeField] private float minTime;
    [SerializeField] private float maxTime;
    [SerializeField] private TimerManager timer;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnFish());
    }

    private void Update()
    {
        
    }
    IEnumerator SpawnFish()
    {
        while (timer.duration > 0)
        {
            float waitTime = Random.Range(minTime, maxTime);

            yield return new WaitForSeconds(waitTime);

            Instantiate(fish[Random.Range(0, fish.Length)], transform.position, Quaternion.identity);
        }
    }
}
