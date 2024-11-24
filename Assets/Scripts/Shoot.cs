using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    [SerializeField] private MeshRenderer mr;
    [SerializeField] private GameObject ammo;
    private bool canFire = true;

    private void Update()
    {
        StartCoroutine(WaitUntilFire());
    }
    IEnumerator WaitUntilFire()
    {
            if (Input.GetMouseButtonDown(0) && canFire)
            {
                Debug.Log("fire");
                StartCoroutine(HideMesh());
            }
        yield return null;
    }

    IEnumerator HideMesh()
    {
        Instantiate(ammo, this.transform.position, Quaternion.identity);
        mr.enabled = false;
        canFire = false;
        yield return new WaitForSeconds(0.5f);
        mr.enabled = true;
        canFire = true;
    }
}
