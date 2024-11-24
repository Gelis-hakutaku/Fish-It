using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncreClass : MonoBehaviour
{
    public static GameObject Encre;

    private void Start() 
    { 
        Encre ??= this.gameObject;
        this.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
        this.gameObject.SetActive(false);
    }
}
