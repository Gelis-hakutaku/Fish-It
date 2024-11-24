using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    [SerializeField] private MeshRenderer mr;
    [SerializeField] private GameObject ammo;
    [SerializeField] private WeaponManager stats;
    [SerializeField] private AudioSource tir;
    private bool canFire = true;

    private void Update()
    {
        StartCoroutine(WaitUntilFire());
    }
    IEnumerator WaitUntilFire()
    {
            if (Input.GetMouseButtonDown(0) && canFire)
            {
                tir.Play();
                StartCoroutine(HideMesh());
            }
        yield return null;
    }

    IEnumerator HideMesh()
    {
        Instantiate(ammo, this.transform.position, Quaternion.identity);
        mr.enabled = false;
        canFire = false;
        yield return new WaitForSeconds(stats.fireRate);
        mr.enabled = true;
        canFire = true;
    }
}
